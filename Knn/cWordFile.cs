using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Knn
{
    class WordFile
    {
        string mPath; //Đường dẫn đến File
        int mDocCount; //Số văn bản trong file
    	Vector[] mArrVector; //Mảng chứa thông tin

        public WordFile(string _path, long _max)
        {
            mPath = _path;
            mArrVector = new Vector[_max + 1];
        }

        public void ReadFile()
        {
			string line;
            string[] tmp = new string[100000];

			//Nếu có đường dẫn file rồi
			if (mPath != "")
			{				
				if (File.Exists(mPath) == false)
				{
                    MessageBox.Show("File " + mPath + " không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);					
					return;
				}

				// Mở file để đọc
				using (StreamReader sr = new StreamReader(mPath))
				{
					mDocCount = 0;
					// Đọc từng dòng cho đến khi hết file
                    do
                    {
                        line = sr.ReadLine();

                        if (line != null)
                        {
                            line = line.Trim();

                            //Gán thông tin vào Vector
                            mArrVector[mDocCount] = new Vector();

                            mArrVector[mDocCount].Data = line;
                            tmp = line.Split(' ');
                            mArrVector[mDocCount].Class = long.Parse(tmp[0]);
                            mArrVector[mDocCount].Pos = mDocCount + 1;

                            //Tăng biến đếm số văn bản train
                            mDocCount++;
                        }
                    } while (line != null);
					sr.Close();
				}				
			}
        }

        public string FilePath
        {
            get {
                return mPath;
            }
            set {
                mPath = value;
            }
        }

        public int DocCount
        {
            get {
                return mDocCount;
            }
            set {
                mDocCount = value;
            }
        }

        public Vector[] ArrVector
        {
            get {
                return mArrVector;
            }
            set {
                mArrVector = value;
            }
        }

   }
}
