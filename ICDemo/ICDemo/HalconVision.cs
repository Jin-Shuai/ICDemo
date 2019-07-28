using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

namespace ICDemo
{
    
    //定义公用图像和区域变量
    public class ImageRegion
    {
        //定义图像
        public HObject m_Image1;
        public HObject m_Image2;
        public HObject m_Image3;
        public HObject m_Image4;
        public HObject m_Image5;
        public HObject m_Image6;
        public HObject m_Image7;
        //定义区域
        public HObject m_Region1;
        public HObject m_Region2;
        public HObject m_Region3;
        public HObject m_Region4;

        public ImageRegion()
        {
            HOperatorSet.GenEmptyObj(out m_Image1);
            HOperatorSet.GenEmptyObj(out m_Image2);
            HOperatorSet.GenEmptyObj(out m_Image3);
            HOperatorSet.GenEmptyObj(out m_Image4);
            HOperatorSet.GenEmptyObj(out m_Image5);
            HOperatorSet.GenEmptyObj(out m_Image6);
            HOperatorSet.GenEmptyObj(out m_Image7);

            HOperatorSet.GenEmptyObj(out m_Region1);
            HOperatorSet.GenEmptyObj(out m_Region2);
            HOperatorSet.GenEmptyObj(out m_Region3);
            HOperatorSet.GenEmptyObj(out m_Region4);
        }
    }

    //定义文件保存路劲
    public class SavePath
    {
        //图像保存路径
        public string m_SavePath;
        //标定图像路径
        public string m_CalibPath;
        //配置文件路劲
        public string m_IniPath;
        //相机内参数组
        public string m_CamParInPath;

        public SavePath()
        {
            m_SavePath = "F:/Image/";
            m_CalibPath = "F:/Image/";
            m_IniPath = Application.StartupPath + "//Set.ini";
            m_CamParInPath = Application.StartupPath + "//CamParIn.ini";
        }
    }

    //定义2个标定线程
    public class ThreadCalibration
    {
        //定义线程启动标志位
        public bool m_bBusy1;
        public bool m_bBusy2;

        //定义线程
        public Thread m_GrabThread1;
        public Thread m_GrabThread2;

        public ThreadCalibration()
        {
            m_bBusy1 = false;
            m_bBusy2 = false;
        }
    }

    public class HalconVision
    {
        #region //A00 单例模式
        private static HalconVision _instance = null;
        public static HalconVision Instance()
        {
            if (_instance == null)
            {
                _instance = new HalconVision();
            }
            return _instance;
        }
        #endregion

        #region //A01 Ini文件读写
        //声明读写INI文件的API函数  
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal,
                                    int size, string filePath);
        //复制内存
        [DllImport("Kernel32.dll")]
        private static extern void CopyMemory(int dest, int source, int size);

        //保存参数到ini文件  
        public void IniWriteValue(string Section, string Key, string Value, string Path)
        {
            WritePrivateProfileString(Section, Key, Value, Path);
        }

        //读取ini文件中的参数   
        public string IniReadValue(string Section, string Key, string Path)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, Path);
            return temp.ToString();
        }
        #endregion

        #region //实例化对象 
        public ImageRegion ImageRegion = new ImageRegion();
        public SavePath SavePath = new SavePath();
        #endregion   
        public void ShowImage(HObject Image, HTuple HalconWindowID)
        {
            //记录图片显示的宽度、高度
            HTuple Width, Heigth;
            //清屏
            HOperatorSet.ClearWindow(HalconWindowID);
            //获取图片长度、宽度
            HOperatorSet.GetImageSize(Image, out Width, out Heigth);
            //设置显示区域
            HOperatorSet.SetPart(HalconWindowID, 0, 0, Heigth, Width);
            //显示图片
            HOperatorSet.DispObj(Image, HalconWindowID);
        }

        public void GetPins(HObject ho_Intensity, out HObject ho_Pins, out HObject ho_IC)
        {



            // Local iconic variables 

            HObject ho_Dark, ho_DarkDilation, ho_ICLarge;
            HObject ho_ICLargeGray, ho_ICDark, ho_ICDilation, ho_SearchSpace;
            HObject ho_SearchSpaceDilation, ho_SearchSpaceUnion, ho_SearchGray;
            HObject ho_SearchMean, ho_PinsRaw, ho_PinsConnect, ho_PinsFilled;
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Pins);
            HOperatorSet.GenEmptyObj(out ho_IC);
            HOperatorSet.GenEmptyObj(out ho_Dark);
            HOperatorSet.GenEmptyObj(out ho_DarkDilation);
            HOperatorSet.GenEmptyObj(out ho_ICLarge);
            HOperatorSet.GenEmptyObj(out ho_ICLargeGray);
            HOperatorSet.GenEmptyObj(out ho_ICDark);
            HOperatorSet.GenEmptyObj(out ho_ICDilation);
            HOperatorSet.GenEmptyObj(out ho_SearchSpace);
            HOperatorSet.GenEmptyObj(out ho_SearchSpaceDilation);
            HOperatorSet.GenEmptyObj(out ho_SearchSpaceUnion);
            HOperatorSet.GenEmptyObj(out ho_SearchGray);
            HOperatorSet.GenEmptyObj(out ho_SearchMean);
            HOperatorSet.GenEmptyObj(out ho_PinsRaw);
            HOperatorSet.GenEmptyObj(out ho_PinsConnect);
            HOperatorSet.GenEmptyObj(out ho_PinsFilled);
            ho_Dark.Dispose();
            HOperatorSet.Threshold(ho_Intensity, out ho_Dark, 0, 50);
            ho_DarkDilation.Dispose();
            HOperatorSet.DilationRectangle1(ho_Dark, out ho_DarkDilation, 14, 14);
            ho_ICLarge.Dispose();
            HOperatorSet.Connection(ho_DarkDilation, out ho_ICLarge);
            ho_ICLargeGray.Dispose();
            HOperatorSet.AddChannels(ho_ICLarge, ho_Intensity, out ho_ICLargeGray);
            ho_ICDark.Dispose();
            HOperatorSet.Threshold(ho_ICLargeGray, out ho_ICDark, 0, 50);
            ho_IC.Dispose();
            HOperatorSet.ShapeTrans(ho_ICDark, out ho_IC, "rectangle2");
            ho_ICDilation.Dispose();
            HOperatorSet.DilationRectangle1(ho_IC, out ho_ICDilation, 5, 1);
            ho_SearchSpace.Dispose();
            HOperatorSet.Difference(ho_ICDilation, ho_IC, out ho_SearchSpace);
            ho_SearchSpaceDilation.Dispose();
            HOperatorSet.DilationRectangle1(ho_SearchSpace, out ho_SearchSpaceDilation, 14,
                1);
            ho_SearchSpaceUnion.Dispose();
            HOperatorSet.Union1(ho_SearchSpaceDilation, out ho_SearchSpaceUnion);
            ho_SearchGray.Dispose();
            HOperatorSet.ReduceDomain(ho_Intensity, ho_SearchSpaceUnion, out ho_SearchGray
                );
            ho_SearchMean.Dispose();
            HOperatorSet.MeanImage(ho_SearchGray, out ho_SearchMean, 15, 15);
            ho_PinsRaw.Dispose();
            HOperatorSet.DynThreshold(ho_SearchGray, ho_SearchMean, out ho_PinsRaw, 5, "light");
            ho_PinsConnect.Dispose();
            HOperatorSet.Connection(ho_PinsRaw, out ho_PinsConnect);
            ho_PinsFilled.Dispose();
            HOperatorSet.FillUp(ho_PinsConnect, out ho_PinsFilled);
            ho_Pins.Dispose();
            HOperatorSet.SelectShape(ho_PinsFilled, out ho_Pins, "area", "and", 10, 100);
            ho_Dark.Dispose();
            ho_DarkDilation.Dispose();
            ho_ICLarge.Dispose();
            ho_ICLargeGray.Dispose();
            ho_ICDark.Dispose();
            ho_ICDilation.Dispose();
            ho_SearchSpace.Dispose();
            ho_SearchSpaceDilation.Dispose();
            ho_SearchSpaceUnion.Dispose();
            ho_SearchGray.Dispose();
            ho_SearchMean.Dispose();
            ho_PinsRaw.Dispose();
            ho_PinsConnect.Dispose();
            ho_PinsFilled.Dispose();

            return;
        }

        public void GetCapacitors(HObject ho_Saturation, HObject ho_Hue, out HObject ho_Capacitors)
        {



            // Local iconic variables 

            HObject ho_Colored, ho_HueColored, ho_Blue;
            HObject ho_BlueConnect, ho_BlueLarge;
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Capacitors);
            HOperatorSet.GenEmptyObj(out ho_Colored);
            HOperatorSet.GenEmptyObj(out ho_HueColored);
            HOperatorSet.GenEmptyObj(out ho_Blue);
            HOperatorSet.GenEmptyObj(out ho_BlueConnect);
            HOperatorSet.GenEmptyObj(out ho_BlueLarge);
            ho_Colored.Dispose();
            HOperatorSet.Threshold(ho_Saturation, out ho_Colored, 100, 255);
            ho_HueColored.Dispose();
            HOperatorSet.ReduceDomain(ho_Hue, ho_Colored, out ho_HueColored);
            ho_Blue.Dispose();
            HOperatorSet.Threshold(ho_HueColored, out ho_Blue, 114, 137);
            ho_BlueConnect.Dispose();
            HOperatorSet.Connection(ho_Blue, out ho_BlueConnect);
            ho_BlueLarge.Dispose();
            HOperatorSet.SelectShape(ho_BlueConnect, out ho_BlueLarge, "area", "and", 150,
                99999);
            ho_Capacitors.Dispose();
            HOperatorSet.ShapeTrans(ho_BlueLarge, out ho_Capacitors, "rectangle2");
            ho_Colored.Dispose();
            ho_HueColored.Dispose();
            ho_Blue.Dispose();
            ho_BlueConnect.Dispose();
            ho_BlueLarge.Dispose();

            return;
        }

        public void GetResistors(HObject ho_Saturation, HObject ho_Hue, out HObject ho_Resistors)
        {



            // Local iconic variables 

            HObject ho_Colored, ho_HueColored, ho_Red;
            HObject ho_RedConnect, ho_RedLarge;
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Resistors);
            HOperatorSet.GenEmptyObj(out ho_Colored);
            HOperatorSet.GenEmptyObj(out ho_HueColored);
            HOperatorSet.GenEmptyObj(out ho_Red);
            HOperatorSet.GenEmptyObj(out ho_RedConnect);
            HOperatorSet.GenEmptyObj(out ho_RedLarge);
            ho_Colored.Dispose();
            HOperatorSet.Threshold(ho_Saturation, out ho_Colored, 100, 255);
            ho_HueColored.Dispose();
            HOperatorSet.ReduceDomain(ho_Hue, ho_Colored, out ho_HueColored);
            ho_Red.Dispose();
            HOperatorSet.Threshold(ho_HueColored, out ho_Red, 10, 19);
            ho_RedConnect.Dispose();
            HOperatorSet.Connection(ho_Red, out ho_RedConnect);
            ho_RedLarge.Dispose();
            HOperatorSet.SelectShape(ho_RedConnect, out ho_RedLarge, "area", "and", 150,
                99999);
            ho_Resistors.Dispose();
            HOperatorSet.ShapeTrans(ho_RedLarge, out ho_Resistors, "rectangle2");
            ho_Colored.Dispose();
            ho_HueColored.Dispose();
            ho_Red.Dispose();
            ho_RedConnect.Dispose();
            ho_RedLarge.Dispose();

            return;
        }

        public void GetMuiltImage(HObject ho_Image, out HObject ho_Red, out HObject ho_Green,
            out HObject ho_Blue, out HObject ho_Hue, out HObject ho_Saturation, out HObject ho_Intensity)
        {


            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Red);
            HOperatorSet.GenEmptyObj(out ho_Green);
            HOperatorSet.GenEmptyObj(out ho_Blue);
            HOperatorSet.GenEmptyObj(out ho_Hue);
            HOperatorSet.GenEmptyObj(out ho_Saturation);
            HOperatorSet.GenEmptyObj(out ho_Intensity);
            ho_Red.Dispose(); ho_Green.Dispose(); ho_Blue.Dispose();
            HOperatorSet.Decompose3(ho_Image, out ho_Red, out ho_Green, out ho_Blue);
            ho_Hue.Dispose(); ho_Saturation.Dispose(); ho_Intensity.Dispose();
            HOperatorSet.TransFromRgb(ho_Red, ho_Green, ho_Blue, out ho_Hue, out ho_Saturation,
                out ho_Intensity, "hsv");

            return;
        }
    }
}
