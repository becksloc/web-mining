using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;


namespace Knn
{
	public partial class frmmain
	{
		public frmmain()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
		#region Default Instance
		
		private static frmmain defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmmain Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmmain();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
		#endregion
		
		//Khai báo các hằng
		const long MaxN = 50001; //số từ tối đa trong từ điển
		const long MaxDoc = 10001; //số văn bản tối đa
		const long MaxTerm = 5001; //số từ tối đa trong 1 văn bản
		const long MaxK = 101; //số K tối đa
		
		//Khai báo các biến toàn cục
		int NumK; //Số K
		long NumTrain; //Số lượng văn bản training
		long NumTest; //Số lượng file test
		long NumTrue; //Số văn bản đặt đúng lớp
		long FromNum; //Test từ văn bản
		long ToNum; //Test đến văn bản
				
		//Tính thời gian chạy
		DateTime StartTime; //Thời gian bắt đầu
		DateTime StopTime; //Thời gian kết thúc

        //Khai báo 2 đối tượng Train và Test tương ứng với 2 file word.train và word.test
        WordFile objTrain;
        WordFile objTest;
						

		//Khởi tạo lại
		private void Reset()
		{
			ProgressBar1.Value = 0;
			txtPrecision.Text = "";
			txtRateErr.Text = "";
			txtResult.Text = "";
			Label7.Text = "0%";
			FromNum = (long)FromVb.Value;
			ToNum = (long)ToVb.Value;
			NumK = (int) (Conversion.Val(cbSelectK.Text));
		}

		//Thực hiện phân lớp
		public void cmdTest_Click(System.Object sender, System.EventArgs e)
		{
			float pre = 0;
            double dis;
            long kq;

			try
			{
				//Dành cho test
				if (OptAll.Checked == true)
				{
					FromNum = 1;
					ToNum = NumTest;
					FromVb.Value = 1;
					ToVb.Value = NumTest;
				}
				if (OptOption.Checked == true)
				{
					FromNum = (long)FromVb.Value;
					ToNum = (long)ToVb.Value;
				}
				if (FromNum <= ToNum)
				{
					//Xoá hết dữ liệu cũ
					StartTime = DateTime.Now;
					Reset();
					txtResult.Text = "";
					txtResult.Text += "K = " + NumK + Constants.vbNewLine;
					txtResult.Text += "Số văn bản trong tập huấn luyện: " + NumTrain + Constants.vbNewLine;
					txtResult.Text += "Số văn bản trong tập test: " + NumTest + Constants.vbNewLine;
					txtResult.Text += "Số văn bản test: " + (ToNum - FromNum + 1) + Constants.vbNewLine;
					txtResult.Text += "Từ " + FromNum + " đến " + ToNum + Constants.vbNewLine;
					txtResult.Text += "=======================================================================" + Constants.vbNewLine;
					
					System.IO.StreamWriter file;
					file = (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.OpenTextFileWriter("Knn.txt", false);
					file.WriteLine("K = " + NumK);
					file.WriteLine("Số văn bản trong tập huấn luyện: " + NumTrain);
					file.WriteLine("Số văn bản trong tập test: " + NumTest);
					file.WriteLine("Số văn bản test: " + (ToNum - FromNum + 1));
					file.WriteLine("Từ " + FromNum + " đến " + ToNum);
					file.WriteLine("=======================================================================");

                    
                    //Xu ly
                    //Duyệt lần lượt từng VectorTest, tính Sim lần lượt với VectorTrain --> Lưu vào mảng KnnArr
                    NumTrue = 0;
                    KnnArr objKnnArr = new KnnArr(NumK, objTrain.DocCount);
                    
                    for (int i = 0; i < objTest.DocCount; i++)
                    {
                        //Tinh SIM cua VectorTest[i] voi lan luot tat ca VectorTrain
                        for (int j = 0; j < objTrain.DocCount; j++)
                        {
                            objKnnArr.ArrKnn[j] = new Knn();
                            objKnnArr.ArrKnn[j].Class = objTrain.ArrVector[j].Class;

                            //Tùy công thức
                            dis = objTest.ArrVector[i].Sim(objTrain.ArrVector[j]);

                            if (rdKieu2.Checked)
                            {
                                dis = 1 / (1 - dis);
                            }
                            else if (rdKieu3.Checked)
                            {
                                dis = 1 / Math.Pow(1 - dis, 2);
                            }

                            objKnnArr.ArrKnn[j].Distance = dis;
                        }

                        //Xử lý VectorTest[i]
                        kq = objKnnArr.ClassMaxTotal();
                        if (objTest.ArrVector[i].Class == kq)
                        {
                            NumTrue++;
                        }

                        //MessageBox.Show(objTest.ArrVector[i].Class + " --- " + objKnnArr.ClassMaxTotal());


                        Application.DoEvents();

                        txtResult.Text += "Văn bản thứ " + (i + 1).ToString() + Constants.vbNewLine;
                        txtResult.Text +=  "Lớp gốc: " + objTest.ArrVector[i].Class + " --> Phân vào lớp: " + kq + Constants.vbNewLine;
                        txtResult.Text += "---------------------------------------------------------------------------" + Constants.vbNewLine;
                        
                        //Ghi ra File
                        file.WriteLine("Lớp gốc: " + objTest.ArrVector[i].Class + " --> Phân vào lớp: " + kq + Constants.vbNewLine);
                        file.WriteLine("---------------------------------------------------------------------------");
                        ProgressBar1.Value += ProgressBar1.Maximum / (int)(ToNum - FromNum + 1);
                        Label7.Text = Strings.Format((double)(i - FromNum + 1) / (ToNum - FromNum + 1), "0.00%");

                        pre = (float)NumTrue / (ToNum - FromNum + 1) * 100;
                        txtPrecision.Text = Strings.Format(pre, "0.00") + "% (" + NumTrue + "/" + (ToNum - FromNum + 1) + ")";
                        txtRateErr.Text = Strings.Format(100 - pre, "0.00") + "% (" + ((ToNum - FromNum + 1) - NumTrue) + "/" + (ToNum - FromNum + 1) + ")";

                    }

					
					ProgressBar1.Value = ProgressBar1.Maximum;
					Label7.Text = "100%";
					
                    float tt;
					float gio = 0;
					float phut = 0;
					float giay = 0;
					
					StopTime = DateTime.Now;
                 
					tt = DateAndTime.DateDiff("s", StartTime, StopTime, FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1);
                    
					if (tt > 0)
					{
						giay = tt % 60;
						tt = tt - giay;
					}
					if (tt > 0)
					{
						phut = tt / 60;
						tt = tt - phut * 60;
					}
					if (tt > 0)
					{
						gio = tt;
					}
					Interaction.MsgBox("Phân lớp hoàn thành!" + '\n' + "Thời gian chạy : " + gio + ":" + Strings.Format(phut, "00") + ":" + Strings.Format(giay, "00"), MsgBoxStyle.Information, "Hoàn thành!");
					file.WriteLine("Độ chính xác: " + Strings.Format(pre, "0.00") + "% (" + NumTrue + "/" + (ToNum - FromNum + 1) + ")");
					file.Close();
				}
				else
				{
					Interaction.MsgBox("Chọn lại văn bản !", MsgBoxStyle.Exclamation, "Lỗi !");
				}
			}
			catch (Exception ex)
			{
                MessageBox.Show(ex.ToString());
			}
		}
		
		public void cmdSelectTrainFile_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				OpenFileDialog1.Title = "Chọn file huấn luyện";
				OpenFileDialog1.Filter = "File huấn luyện (*.train)|*.train| Tất cả các file(*.*)|*.*";
				OpenFileDialog1.FileName = "";
				if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					txtTrainFilename.Text = OpenFileDialog1.FileName;
				}
			}
			catch
			{
				goto Err;
			}
			
Err:
			return;
			
		}
		
		public void cmdSelectTestfile_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				OpenFileDialog1.Title = "Chọn file test";
				OpenFileDialog1.Filter = "File test (*.test)|*.test| Tất cả các file (*.*)|*.*";
				OpenFileDialog1.FileName = "";
				if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					txtTestFileName.Text = OpenFileDialog1.FileName;
				}
			}
			catch
			{
				goto Err;
			}
			
Err:
			return;
		}
		
		public void cbSelectK_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				NumK = int.Parse(cbSelectK.Text);
			}
		}
		
		public void cbSelectK_LostFocus(object sender, System.EventArgs e)
		{
			NumK = int.Parse(cbSelectK.Text);
		}
		
		public void cbSelectK_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			try
			{
				NumK = int.Parse(cbSelectK.Text);
			}
			catch
			{
				goto Err;
			}
			
Err:
			return;
		}
		
		public void cmdExit_Click(System.Object sender, System.EventArgs e)
		{
			ProjectData.EndApp();
		}
		
		public void frmmain_Load(System.Object sender, System.EventArgs e)
		{
			cmdTest.Enabled = false;
            //Added 2010/01/02
            txtTrainFilename.Text = Application.StartupPath + "\\word.train";
            txtTestFileName.Text = Application.StartupPath + "\\word.test";
		}
		
		public void mnuOpentrainingfile_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				OpenFileDialog1.Title = "Chọn file huấn luyện";
				OpenFileDialog1.Filter = "File huấn luyện (*.train)|*.train| Tất cả các file(*.*)|*.*";
				OpenFileDialog1.FileName = "";
				if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					txtTrainFilename.Text = OpenFileDialog1.FileName;
				}
			}
			catch
			{
				goto Err;
			}
			
Err:
			return;
		}
		
		public void mnuOpentestfile_Click(object sender, System.EventArgs e)
		{
			try
			{
				OpenFileDialog1.Title = "Chọn file test";
				OpenFileDialog1.Filter = "File test (*.test)|*.test| Tất cả các file (*.*)|*.*";
				OpenFileDialog1.FileName = "";
				if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					txtTestFileName.Text = OpenFileDialog1.FileName;
				}
			}
			catch
			{
				goto Err;
			}
			
Err:
			return;
		}
		
		public void AboutToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{			
            MessageBox.Show("Chương trình mô phỏng thuật toán k-nearest neighbour" + '\r' + '\n' + "Tác giả: Nguyễn Thanh Bình - Lớp K15 Hệ thống thông tin", "Gioi thieu", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		public void mnuExit_Click(System.Object sender, System.EventArgs e)
		{
			ProjectData.EndApp();
		}
		
		public void cmdReadData_Click(System.Object sender, System.EventArgs e)
		{
			Reset();
			//Kiểm tra K
			if (NumK > 101)
			{
				Interaction.MsgBox("K chọn quá lớn! Hãy chọn lại !", MsgBoxStyle.Exclamation, "Lỗi !");
				return;
			}
			else if (NumK % 2 == 0)
			{
				Interaction.MsgBox("K phải là số lẻ !", MsgBoxStyle.Exclamation, "Lỗi !");
				return;
			}
			txtResult.Text += "K = " + NumK + Constants.vbNewLine;
			if ((txtTestFileName.Text == "") || (txtTrainFilename.Text) == "")
			{
				Interaction.MsgBox("Chưa có đầy đủ dữ liệu huấn luyện và test !", MsgBoxStyle.Exclamation, "Lỗi !");
				return;
			}

			//Train File
            objTrain = new WordFile(txtTrainFilename.Text, MaxDoc);
            objTrain.ReadFile();
            NumTrain = objTrain.DocCount;
			
            txtResult.Text += "Số văn bản trong tập huấn luyện: " + NumTrain + Constants.vbNewLine;
			if (NumTrain < NumK)
			{
				Interaction.MsgBox("Số lượng văn bản huấn luyện quá ít !", MsgBoxStyle.Exclamation, "Lỗi !");
				cmdTest.Enabled = true;
				txtResult.Text = "";
				return;
			}
			ProgressBar1.Value = 0;

			//Test File
            objTest = new WordFile(txtTestFileName.Text, MaxDoc);
            objTest.ReadFile();
            NumTest = objTest.DocCount;
			
            txtResult.Text += "Số văn bản trong tập test: " + NumTest + Constants.vbNewLine;
			cmdTest.Enabled = true;
			FromNum = 1;
			ToNum = NumTest;
			FromVb.Maximum = NumTest;
			ToVb.Maximum = NumTest;
		}
		
		public void OptOption_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			FromVb.Enabled = true;
			ToVb.Enabled = true;
		}
		
		public void OptAll_CheckedChanged(System.Object sender, System.EventArgs e)
		{
			FromVb.Enabled = false;
			ToVb.Enabled = false;
		}
		
	}
	
}
