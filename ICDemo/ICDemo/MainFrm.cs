using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;

namespace ICDemo
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        HalconVision HalconVision = new HalconVision();

        private void MainFrm_Load(object sender, EventArgs e)
        {//窗体加载事件

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {//打开图像
            OpenFileDialog Dlg = new OpenFileDialog();

            Dlg.Filter = "(*.bmp; *.jpg; *.png)|*.bmp; *.jpg; *.png";
            Dlg.Multiselect = false;
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //定义图像变量
                    HOperatorSet.GenEmptyObj(out HalconVision.ImageRegion.m_Image1);
                    //打开图像
                    HalconVision.ImageRegion.m_Image1.Dispose();
                    HOperatorSet.ReadImage(out HalconVision.ImageRegion.m_Image1, Dlg.FileName);
                    //获取图像大小并显示全图
                    HalconVision.ShowImage(HalconVision.ImageRegion.m_Image1, hWindow1.HalconWindow);

                    //内存释放
                    Dlg.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("图像打开失败！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnMultiChannel_Click(object sender, EventArgs e)
        {//显示多通道图像
            HalconVision.GetMuiltImage(HalconVision.ImageRegion.m_Image1,out HalconVision.ImageRegion.m_Image2, out HalconVision.ImageRegion.m_Image3, out HalconVision.ImageRegion.m_Image4, 
                        out HalconVision.ImageRegion.m_Image5, out HalconVision.ImageRegion.m_Image6, out HalconVision.ImageRegion.m_Image7);
            //获取图像大小并显示全图
            HalconVision.ShowImage(HalconVision.ImageRegion.m_Image2, hWindow1.HalconWindow);
            HalconVision.ShowImage(HalconVision.ImageRegion.m_Image3, hWindow2.HalconWindow);
            HalconVision.ShowImage(HalconVision.ImageRegion.m_Image4, hWindow3.HalconWindow);
            HalconVision.ShowImage(HalconVision.ImageRegion.m_Image5, hWindow4.HalconWindow);
            HalconVision.ShowImage(HalconVision.ImageRegion.m_Image6, hWindow5.HalconWindow);
            HalconVision.ShowImage(HalconVision.ImageRegion.m_Image7, hWindow6.HalconWindow);
        }

        private void btnResistors_Click(object sender, EventArgs e)
        {//测试电阻器
            HOperatorSet.SetDraw(hWindow1.HalconWindow, "margin");
            HOperatorSet.SetLineWidth(hWindow1.HalconWindow, 3);
            HOperatorSet.SetColor(hWindow1.HalconWindow, "green");

            HalconVision.GetResistors(HalconVision.ImageRegion.m_Image6, HalconVision.ImageRegion.m_Image5, out HalconVision.ImageRegion.m_Region1);
            HalconVision.ShowImage(HalconVision.ImageRegion.m_Image2, hWindow1.HalconWindow);
            HOperatorSet.DispObj(HalconVision.ImageRegion.m_Region1, hWindow1.HalconWindow);
        }

        private void btnCapacitors_Click(object sender, EventArgs e)
        {//测试电容器
            HOperatorSet.SetDraw(hWindow2.HalconWindow, "margin");
            HOperatorSet.SetLineWidth(hWindow2.HalconWindow, 3);
            HOperatorSet.SetColor(hWindow2.HalconWindow, "blue");

            HalconVision.GetCapacitors(HalconVision.ImageRegion.m_Image6, HalconVision.ImageRegion.m_Image5, out HalconVision.ImageRegion.m_Region2);
            HalconVision.ShowImage(HalconVision.ImageRegion.m_Image3, hWindow2.HalconWindow);
            HOperatorSet.DispObj(HalconVision.ImageRegion.m_Region2, hWindow2.HalconWindow);
        }

        private void btnPins_Click(object sender, EventArgs e)
        {//测试Pin
            HOperatorSet.SetDraw(hWindow3.HalconWindow, "margin");
            HOperatorSet.SetLineWidth(hWindow3.HalconWindow, 3);
            HOperatorSet.SetColor(hWindow3.HalconWindow, "yellow");

            HalconVision.GetPins(HalconVision.ImageRegion.m_Image7, out HalconVision.ImageRegion.m_Region3, out HalconVision.ImageRegion.m_Region4);
            HalconVision.ShowImage(HalconVision.ImageRegion.m_Image4, hWindow3.HalconWindow);
            HOperatorSet.DispObj(HalconVision.ImageRegion.m_Region3, hWindow3.HalconWindow);
            HOperatorSet.DispObj(HalconVision.ImageRegion.m_Region4, hWindow3.HalconWindow);         
        }

        private void btnShow_Click(object sender, EventArgs e)
        {//综合显示
            HOperatorSet.SetDraw(hWindow5.HalconWindow, "margin");
            HalconVision.ShowImage(HalconVision.ImageRegion.m_Image1, hWindow5.HalconWindow);
            HOperatorSet.SetLineWidth(hWindow5.HalconWindow, 3);
            HOperatorSet.SetColor(hWindow5.HalconWindow, "green");
            HOperatorSet.DispObj(HalconVision.ImageRegion.m_Region1, hWindow5.HalconWindow);
            HOperatorSet.SetColor(hWindow5.HalconWindow, "blue");
            HOperatorSet.DispObj(HalconVision.ImageRegion.m_Region2, hWindow5.HalconWindow);
            HOperatorSet.SetColor(hWindow5.HalconWindow, "yellow");
            HOperatorSet.DispObj(HalconVision.ImageRegion.m_Region3, hWindow5.HalconWindow);
            HOperatorSet.DispObj(HalconVision.ImageRegion.m_Region4, hWindow5.HalconWindow);
        }
    }
}
