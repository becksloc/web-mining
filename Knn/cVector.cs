using System;
using System.Collections.Generic;
using System.Text;

namespace Knn
{
    class Vector
    {
        protected string _data;  //Dữ liệu của Vector: là 1 dòng trong File Train/Test
        protected long _class;  //Vector này thuộc lớp nào
        protected long _pos;  //Vị trí của Vector này trong File

        struct Word
        {
            public long Pos;
            public long Count;
        }

        //Các phương thức
        private long SplitVector(string _str, Word[] _text)
        {
            string[] tmp1;
            string[] tmp2;

            tmp1 = _str.Split(' ');

            //Bỏ qua phần tử đầu tiên (là Lớp) --> i = 1
            for (int i = 1; i < tmp1.Length; i++)
            {
                tmp2 = tmp1[i].Split(':');
                _text[i - 1].Pos = long.Parse(tmp2[0]);
                _text[i - 1].Count = long.Parse(tmp2[1]);
            }

            return tmp1.Length - 1; //Trả về số từ trong văn bản (Vector), ko kể "lớp" (vị trí 0)
        }

        public double Sim(Vector _obj)
        {
            Word[] ArrWords1 = new Word[10000];
            Word[] ArrWords2 = new Word[10000];
            long leng1, leng2; //Lưu độ dài của các văn bản (số từ). Có thể sử dụng luôn: ArrWords1.Length
            double tu, mau, mau1, mau2, simxy;

            //Tách các từ ở file Test thành (vị trí, số lần xuất hiện) --> Đưa vào mảng ArrWords1
            leng1 = SplitVector(_data, ArrWords1);
            //Tách các từ ở file Train thành (vị trí, số lần xuất hiện) --> Đưa vào mảng ArrWords2
            leng2 = SplitVector(_obj.Data, ArrWords2);

            tu = mau = mau1 = mau2 = 0; //Khởi gán

            //2 mảng text1[i] và text2[i] không tương đồng "Vị trí lớp"
            //text1 có "vị trí lớp": 1 3 6 8
            //text2 có "vị trí lớp": 1 2 3 5 6 8 9  --> đem text1[i] đi tìm text2[j] có "vị trí lớp" giống nhau
            for (int i = 0; i < leng1; i++)
            {
                for (int j = 0; j < leng2; j++)
                {
                    if (ArrWords1[i].Pos == ArrWords2[j].Pos)
                    {
                        tu += ArrWords1[i].Count * ArrWords2[j].Count;
                    }
                }
            }

            for (int i = 0; i < leng1; i++)
            {
                mau1 += Math.Pow(ArrWords1[i].Count, 2);
            }

            for (int i = 0; i < leng2; i++)
            {
                mau2 += Math.Pow(ArrWords2[i].Count, 2);
            }
            mau = Math.Sqrt(mau1) * Math.Sqrt(mau2);


            if (tu == mau)
            {
                simxy = Math.Pow(2, 20) - 1;
            }
            else
            {
                simxy = tu / mau;
            }

            return simxy;
        }


        //Các thuộc tính
        public string Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        public long Class
        {
            get
            {
                return _class;
            }
            set
            {
                _class = value;
            }
        }

        public long Pos
        {
            get
            {
                return _pos;
            }
            set
            {
                _pos = value;
            }
        }
    }
}
