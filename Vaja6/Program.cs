using System.IO;

namespace vaja6 {

  // Enumerator za tip poklica
    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

  public int x = 666;

	// Se en komentar
    class Igralec {
        public int id;
        public string u_ime;
        public string u_geslo;
        public static int stIg = 1;

        public Igralec() {
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }

  public Igralec(string u_ime, string u_geslo, int stIg, int id)
   {
       this.u_ime = u_ime;
       this.u_geslo = u_geslo;
       this.id =  Igralec.stIg;
       stIg++;
   }
   public Igralec(Igralec Igr)
   {
      u_ime = Igr.u_ime;
      u_geslo = Igr.u_geslo;
       id = Igr.id;
       stIg++;
   }
		// dobi ID
        public int Id {
            get
            {
                return id;
            }
        }
        // pridobi ime in ga nastavi        
        public string U_ime {
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }

		//pridobi in nastavi geslo
        public string U_geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }

		//pridobi stevilo igralcov
        public static int StIg
        {
            get { return stIg; }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
