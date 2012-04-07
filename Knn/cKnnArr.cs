using System;
using System.Collections.Generic;
using System.Text;

namespace Knn
{
    class KnnArr
    {
        Knn[] mArrKnn; //Mảng chứa thông tin
        int mK; //Số K
        TotalDisClass[] mDisByClass;

        struct TotalDisClass {
            public double TotalDis;
            public long Class;
        }

        public KnnArr(int _k, long _max)
        {
            mK = _k;
            mArrKnn = new Knn[_max];
            mDisByClass = new TotalDisClass[51];  //Cần tạo số phần tử == Số hiệu Class lớn nhất
        }

        //Sắp xếp ArrKnn giảm dần theo Distance
        private void Sort()
        {
            Knn tmp = new Knn();

            for (int i = 0; i < mArrKnn.Length - 1; i++)
            {
                for (int j = i + 1; j < mArrKnn.Length; j++)
                {
                    if (mArrKnn[i].Distance < mArrKnn[j].Distance)
                    {
                        tmp = mArrKnn[i];
                        mArrKnn[i] = mArrKnn[j];
                        mArrKnn[j] = tmp;
                    }
                }
            }
        }

        //Tính khoảng cách cho K phần từ đầu tiên (sau khi đã sắp xếp)
        private void DistanceByClass()
        {
            //Sắp xếp ArrKnn giảm dần theo Distance
            Sort();

            //Khởi tạo
            for (int i = 0; i < 51; i++)  //Chỉ cần chạy đến 50. Vì số hiệu lớp trong bộ DLieu <= 50
            {
                mDisByClass[i].TotalDis = 0;
                mDisByClass[i].Class = 0;
            }

            //Chỉ tính tổng theo lớp của các Knn đủ tiêu chuẩn (sau khi đã Sort). Không cần xóa bớt KnnArr
            for (int i = 0; i < mK; i++)
            {
                //Tính tổng theo từng lớp
                mDisByClass[mArrKnn[i].Class].TotalDis += mArrKnn[i].Distance;
                mDisByClass[mArrKnn[i].Class].Class = mArrKnn[i].Class;
            }
        }

        //Chọn ra thằng có Tổng Distance theo Class to nhất
        public long ClassMaxTotal()
        {
            //Tính tổng theo từng lớp
            DistanceByClass();

            TotalDisClass max;
            //Tìm lớp có TotalDis lớn nhất
            max = mDisByClass[0];
            int pos_max = 0;
            for (int i = 1; i < 51; i++)
            {
                if (mDisByClass[i].TotalDis > max.TotalDis)
                {
                    max = mDisByClass[i];
                    pos_max = i;
                }
            }          

            return max.Class;
        }

        //Các thuộc tính
        public Knn[] ArrKnn
        {
            get
            {
                return mArrKnn;
            }
            set
            {
                mArrKnn = value;
            }
        }

        public int K
        {
            get
            {
                return mK;
            }
            set
            {
                mK = value;
            }
        }

    }
}
