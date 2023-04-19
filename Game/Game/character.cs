namespace Game
{
    public class Character
    {
        
            public string nick;
            public int sila;
            public int odpornosc;
            public int hp;
            public int szczescie;
            public double damage;
            
            public Character(string nick, int sila, int odpornosc, int hp, int szczescie, double damage)
            {
                this.nick = nick;
                this.sila = sila;
                this.odpornosc = odpornosc;
                this.hp = hp;
                this.szczescie = szczescie;
                this.damage = damage;
            }
            
            public string getNick()
            {
                return nick;
            }

            /// <summary>Pobierz nazwisko klienta</summary>
            public int getSila()
            {
                return sila;
            }

            /// <summary>Pobierz numer konta klienta</summary>
            public int getOdpornosc()
            {
                return odpornosc;
            }

            /// <summary>Pobierz stan konta klienta w groszach</summary>
            public int getHp()
            {
                return hp;
            }

            /// <summary>Pobierz PIN</summary>
            public int getSzczescie()
            {
                return szczescie;
            }
            
            public double getDamage()
            {
                return damage;
            }
            
    }

    public class Gekomonster
    {
        public string nick;
        public int sila;
        public int odpornosc;
        public int hp;
        public int szczescie;
        public double damage;

        public Gekomonster(string nick, int sila, int odpornosc, int hp, int szczescie, double damage)
        {
            this.nick = nick;
            this.sila = sila;
            this.odpornosc = odpornosc;
            this.hp = hp;
            this.szczescie = szczescie;
            this.damage = damage;
        }
            
        public string getNick()
        {
            return nick;
        }

        /// <summary>Pobierz nazwisko klienta</summary>
        public int getSila()
        {
            return sila;
        }

        /// <summary>Pobierz numer konta klienta</summary>
        public int getOdpornosc()
        {
            return odpornosc;
        }

        /// <summary>Pobierz stan konta klienta w groszach</summary>
        public int getHp()
        {
            return hp;
        }

        /// <summary>Pobierz PIN</summary>
        public int getSzczescie()
        {
            return szczescie;
        }

        public double getDamage()
        {
            return damage;
        }
        
    }
}