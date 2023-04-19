using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Game
{
    public partial class MainPage : ContentPage
    {
        private Character player;
        private Gekomonster gekon;
        int silver;

        public MainPage()
        {
            InitializeComponent();
            DaneWpisane();
        }

        public void DaneWpisane()
        {
            player = new Character(Nickname.Text, Int32.Parse(SilaPlayer1.Text), Int32.Parse(OdpornoscPlayer1.Text),
                Int32.Parse(ZyciePlayer1.Text), Int32.Parse(SzczesciePlayer1.Text), 10);
            DamageP1.Text = "Damage " + Convert.ToString(player.sila * player.damage);

            gekon = new Gekomonster(NickEnemy.Text, Int32.Parse(SilaPlayer2.Text), Int32.Parse(OdpornoscPlayer2.Text),
                Int32.Parse(ZyciePlayer2.Text), Int32.Parse(SzczesciePlayer2.Text), 25);

            HpPlayer1.Maximum = player.hp;
            HpPlayer1.Value = HpPlayer1.Maximum;
            HpPlayer2.Maximum = gekon.hp;
            HpPlayer2.Value = HpPlayer2.Maximum;
            HpPlayer1Lbl.Text = Convert.ToString(HpPlayer1.Value);
            HpPlayer2Lbl.Text = Convert.ToString(HpPlayer2.Value);

        }


        private void AttackBtn_OnClicked(object sender, EventArgs e)
        {
           losowanie();
            
            int x = Convert.ToInt32(HpPlayer2.Value - player.damage);
            HpPlayer2.Value = x;
            HpPlayer2Lbl.Text = Convert.ToString(x);
            Random rng = new Random();
            Thread.Sleep(rng.Next(1, 2) * 1000);
            int y = Convert.ToInt32(HpPlayer1.Value - gekon.damage);
            HpPlayer1.Value = y;
            HpPlayer1Lbl.Text = Convert.ToString(y);
            if (HpPlayer1.Value <= 0)
            {
                DisplayAlert("WARNING", "zginales odradzasz sie na nowo za smierc zarabiasz 5 silver coin", "ok");
                HpPlayer1.Value = player.hp;
                HpPlayer1Lbl.Text = Convert.ToString(player.hp);
                LblSilver.Text = Convert.ToString(silver += 5);
            }else if (HpPlayer2.Value <= 0)
            {
                DisplayAlert("WARNING", "Pokonales skurczybyka + 200 silver coina", "ok");
                HpPlayer2.Value = gekon.hp;
                HpPlayer2Lbl.Text = Convert.ToString(gekon.hp);
                LblSilver.Text = Convert.ToString(silver += 200);
            }
        }

        
        
        void losowanie()
        {
            Random rngdmg = new Random();
            int p = rngdmg.Next(0, 10);
            if (p % 2 == 0)
            {
                Random dodaj = new Random();
                double d = dodaj.Next(10, 20);
                player.damage += d;
            }
            else
            {
                Random odejmij = new Random();
                double o = odejmij.Next(5, 10);
                player.damage += o;
            }

            
            
            Random rngdmg2 = new Random();
            int g = rngdmg2.Next(0, 10);
            if (g % 2 == 0)
            {
                Random dodaj2 = new Random();
                double d2 = dodaj2.Next(10, 20);
                gekon.damage += d2;
            }
            else
            {
                Random odejmij2 = new Random();
                double o2 = odejmij2.Next(5, 10);
                player.damage += o2;
            }
        }

        private void UpgradeBtn_OnClicked(object sender, EventArgs e)
        {
                Application.Current.MainPage = new stats();
        }
    }
}