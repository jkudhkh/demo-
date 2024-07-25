using System;
namespace Application
{
    class Problem62
    {
        public string firstname;

        public string lastname;

        public Problem62(string firstnames, string lastnames)
        {
           firstname = firstnames;
           
           lastname = lastnames;
        }

        public void showfullname()
        {
            Console.WriteLine("firstname: " + firstname + " lastname: " + lastname);
        }
        
    
    
        public static void solution()
        {
        Problem62 nasa = new Problem62("Nisha", "Shrestha");
        Problem62 nasa1 = new Problem62("Namrata", "Rana");
        Problem62 nasa2 = new  Problem62("Prabisha", "Pakhrin");
        Problem62 nasa3 = new Problem62("Pabitra", "Thapa");

        nasa.showfullname();
        nasa1.showfullname();
        nasa2.showfullname();
        nasa3.showfullname();

        }
        } 

 }
    
