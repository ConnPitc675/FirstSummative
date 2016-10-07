using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

//

namespace FirstSummative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openCard_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.keyStroke);
            SolidBrush starBrush = new SolidBrush(Color.White);
            Pen starPen = new Pen(Color.White, 2);
            Graphics formGraphics = this.CreateGraphics();

            openCard.Visible = false;

            formGraphics.FillEllipse(starBrush, 118, 28, 15, 15);
            Thread.Sleep(1000);

            formGraphics.DrawLine(starPen, 121, 31, 139, 81);
            formGraphics.FillEllipse(starBrush, 136, 78, 10, 10);
            Thread.Sleep(1000);

            formGraphics.DrawLine(starPen, 123, 33, 146, 107);
            formGraphics.FillEllipse(starBrush, 143, 104, 11, 11);
            Thread.Sleep(1000);

            formGraphics.DrawLine(starPen, 146, 107, 133, 154);
            formGraphics.FillEllipse(starBrush, 131, 151, 7, 7);
            Thread.Sleep(1000);

            formGraphics.DrawLine(starPen, 146, 107, 213, 155);
            formGraphics.FillEllipse(starBrush, 210, 152, 17, 17);
            Thread.Sleep(1000);

            starInfo.Text = "C";
            Thread.Sleep(50);
            player.Play();
            Refresh();
            starInfo.Text = "Ca";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Can";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Canc ";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cance ";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer   ";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer i  ";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is  ";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is o ";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is on ";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one ";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one o";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of ";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of t";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of th";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the ";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the t";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the tw";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twe";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twel";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelv";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve ";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve z";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zo";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zod";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodi";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodia";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac ";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac c";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac co";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac con";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac cons";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac const";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac conste";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constel";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constell";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constella";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellat";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellati";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellatio";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellation";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, ";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, i";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it'";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's ";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's n";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's na";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's nam";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name ";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name i";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is ";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is l";
            Thread.Sleep(50);
             
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is la";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is lat";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is lati";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin f";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin fo";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for c";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for cr ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for cra";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. P ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. Pe ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. Peo ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. Peop ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. Peopl";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People  ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People b ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People bo";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People bor";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born u";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born un";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born und ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born unde";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under t";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under th";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the c";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the ca";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the can";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the canc";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cance";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer s";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer si";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sig";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign,  ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, w ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, wh ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, whi ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, whic ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which  ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which i";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is b";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is be";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is bet";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is betw";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is betwe";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is betwee";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between t";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between th";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the d";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the da";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dat";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the date ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates o ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of  ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of J ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of Ju ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of Jun ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June  ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 2 ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21  ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 a ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 an ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and  ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and J ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and Ju ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and Jul ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July  ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 2 ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22 ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22,  ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, a ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, ar ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are  ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are s ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are sa ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are sai ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said  ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said t ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to  ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to b ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be  ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be e ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be em ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emo ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emot ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emoti ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotio ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotion ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotiona ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, p ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, pe ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, per ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, pers ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persu ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persua ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuas ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasi ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasiv ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive,  ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, p ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pe ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pes ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pess ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessi ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessim ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimi ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimis ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimist ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimisti ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimistic ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimistic a ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimistic an ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimistic and  ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimistic and m ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimistic and ma ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimistic and man ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimistic and mani ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimistic and manip ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimistic and manipu ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimistic and manipul ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimistic and manipula";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimistic and manipulat";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimistic and manipulati";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimistic and manipulativ";
            Thread.Sleep(50);  
            Refresh();
            starInfo.Text = "Cancer is one of the twelve zodiac constellations, it's name is latin for crab. People born under the cancer sign, which is between the dates of June 21 and July 22, are said to be emotional, persuasive, pessimistic and manipulative.";
            Refresh();
        }
    }
}
