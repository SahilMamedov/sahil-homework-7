using System;

namespace task
{
    class User
    {
        private string _username;
        private string _password;
        private int _age;
       

        public void Info()
        {
            Console.WriteLine("--------------");
            Console.WriteLine($"Username: {_username} \n" +
                $"Age: {_age} \n" +
                $"Password: {_password} ");
            Console.WriteLine("you successfully registered");
          
        }
        

        public string username
        {
            get
            {

                return _username;
               
            }
            set
            {
                _username = value;
            }
        }

        private string number(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {


                if (char.IsNumber(num[i]))
                {
                    _password = num;
                    return num;
                }

            }

            Console.WriteLine("Please enter minumum one number ");
            return null;    
           

        }






        private string Boyukherif(string pasword)
        {   

            for (int i = 0; i < pasword.Length; i++)
            {


                if (char.IsUpper(pasword[i]))
                {
                    _password = pasword;
                    return pasword;

                }
                
            }
            Console.WriteLine("Please enter minumum one capital letter");
            return null;

        }
        public string password
        {
            get
            {
                return _password;
              

            }
            set
            {
                if (value.Length >= 8 )
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                       

                        if (char.IsWhiteSpace(value[i]))
                        {
                            Console.WriteLine("Do not enter space");
                            return;
                        }
                    }
                  
                    Boyukherif(value);
                    number(value);
                    Info();

                }
                else
                {
                    Console.WriteLine("You have to enter minumum eight character");
                   
                    
                }
              
                _password = value;

            }


        }

        public int age
        {

            get
            {
                
                return _age;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("you can not enter below zero");
                    return;
                }
                _age = value;
              
            }
            

        }

        



    }
}
