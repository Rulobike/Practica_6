using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace imagenes
{
    public partial class MainPage : CarouselPage
    {
        Int32 like = 0;
        Int32 nlike = 0;
        Int32 img1 = 0;
        Int32 img2 = 0;
        Int32 img3 = 0;
        Int32 img4 = 0;
        Int32 img5 = 0;
        Int32 img6 = 0;
        Int32 img7 = 0;
        Int32 img8 = 0;
        Int32 img9 = 0;
        Int32 img0 = 0;
        Int32 img11 = 0;
        Int32 img22 = 0;
        Int32 img33 = 0;
        Int32 img44 = 0;
        Int32 img55 = 0;
        Int32 img66 = 0;
        Int32 img77 = 0;
        Int32 img88 = 0;
        Int32 img99 = 0;
        Int32 img00 = 0;


        public MainPage()
        {
            InitializeComponent();
           
        }

        private void Mg1(object sender, EventArgs e)
        {
            img1 = 1;
            if (img1 == 1)
            {
                like = 1;
            }
        }

        private void Ng1(object sender, EventArgs e)
        {
            img2 = 0;

            if (img2 == 0)
            {
                nlike = 1;
            }
        }

        private void Mg2(object sender, EventArgs e)
        {
            img3 = 1;
            if (img3 == 1)
            {
                like = like + 1;
            }
        }

        private void Ng2(object sender, EventArgs e)
        {
            img4 = 0;

            if (img4 == 0)
            {
                nlike = nlike + 1;
            }
        }
        private void Mg3(object sender, EventArgs e)
        {
            img5 = 1;

            if (img5 == 1)
            {
                like = like + 1;
            }
        }
        private void Ng3(object sender, EventArgs e)
        {
            img6 = 0;

            if (img6 == 0)
            {
                nlike = nlike + 1;
            }
        }
        private void Mg4(object sender, EventArgs e)
        {
            img7 = 1;

            if (img7 == 1)
            {
                like = like + 1;
            }
        }
        private void Ng4(object sender, EventArgs e)
        {
            img8 = 0;

            if (img8 == 0)
            {
                nlike = nlike + 1;
            }
        }

        private void Mg5(object sender, EventArgs e)
        {
            img9 = 1;

            if (img9 == 1)
            {
                like = like + 1;
            }
        }

        private void Ng5(object sender, EventArgs e)
        {
            img0 = 0;

            if (img0 == 0)
            {
                nlike = nlike + 1;
            }
        }

        private void Mg6(object sender, EventArgs e)
        {
            img11 = 1;

            if (img11 == 1)
            {
                like = like + 1;
            }

        }

        private void Ng6(object sender, EventArgs e)
        {
            img22 = 0;

            if (img22 == 0)
            {
                nlike = nlike + 1;
            }

        }

        private void Mg7(object sender, EventArgs e)
        {
            img33 = 1;

            if (img33 == 1)
            {
                like = like + 1;
            }
        }

        private void Ng7(object sender, EventArgs e)
        {
            img44 = 0;

            if (img44 == 0)
            {
                nlike = nlike + 1;
            }
        }

        private void Mg8(object sender, EventArgs e)
        {
            img55 = 1;

            if (img55 == 1)
            {
                like = like + 1;
            }
        }

        private void Ng8(object sender, EventArgs e)
        {
            img66 = 0;

            if (img66 == 0)
            {
                nlike = nlike + 1;
            }
        }

        private void Mg9(object sender, EventArgs e)
        {
            img77 = 1;

            if (img77 == 1)
            {
                like = like + 1;
            }
        }

        private void Ng9(object sender, EventArgs e)
        {
            img88 = 0;

            if (img88 == 0)
            {
                nlike = nlike + 1;
            }

        }

        private void Mg10(object sender, EventArgs e)
        {
            img99 = 1;

            if (img99 == 1)
            {
                like = like + 1;
            }

      
        }
        private void Ng10(object sender, EventArgs e)
        {
            img00 = 0;

            if (img00 == 0)
            {
                nlike = nlike + 1;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("N° de imagenes que te gustaron", resultado.Text + like, "OK");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("N° de imagenes que no gustaron", resultado.Text + nlike, "OK");
        }
    }
}
