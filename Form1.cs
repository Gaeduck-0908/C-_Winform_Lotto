using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Label[] LottoArray = new Label[] { metroLabel1, metroLabel2, metroLabel3, metroLabel4, metroLabel5, metroLabel6 }; //라벨 배열

            //랜덤 라이브러리
            Random ran = new Random();

            //로또 칸 할당
            for (int lottoindex = 0; lottoindex < LottoArray.Length; lottoindex++)
            {
                int lottoCheckIndex = lottoindex; //현재 인덱스
                int lottonumber = ran.Next(1, 46); //난수 생성
                for (; lottoCheckIndex >= 0; lottoCheckIndex--) //인덱스 확인
                {
                    if (LottoArray[lottoCheckIndex].Text == lottonumber.ToString()) //중복값 확인
                    {
                        lottoCheckIndex = lottoindex;
                        lottonumber = ran.Next(1, 46); //새롭게 난수 생성
                    }
                }
                LottoArray[lottoindex].Text = lottonumber.ToString(); //난수 String Conversion

            }
        }
    }
}
