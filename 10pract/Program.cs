namespace shop2
{
    internal class Program
    {
        public enum roule { кассир, админ, кладовщик, бухгалтер, кадровик }
        public enum key { zerokey, UpArrow, DownArrow, LeftArrow, RightArrow, Escape, Enter, F1, F2, F10, S }
        static user curentuser;
        static List<user> logins = new List<user>();
        static List<people> peoplels = new List<people>();
        static List<goods> goodsss = new List<goods>();

        public struct user
        {
            public int id;
            public string login;
            public string password;
            public roule roule;
        }
        public struct people
        {
            public int id;
            public string famelename;
            public string name;
            public string fathername;
            public string numberpassport;
            public roule roule;
            public int salary;
        }
        public struct goods
        {
            public int id;
            public string name;
            public int cost;
            public int quantity;
        }
        internal interface Icrud
        {
            public void create();
            public void read();
            public void update();
            public void delete();
            public void find();
        }

        public class admin : Icrud
        {
            menu menuadm;
            public bool stupid()
            {
                Console.SetCursorPosition(Console.WindowLeft / 2, Console.WindowTop / 2);
                Console.WriteLine("Вы в этом уверенны y/n");
                ConsoleKeyInfo cki;
                do
                {
                    cki = Console.ReadKey();
                } while ((cki.Key != ConsoleKey.Y) && (cki.Key != ConsoleKey.N));
                if (cki.Key != ConsoleKey.Y) { return true; } else { return false; }
            }

            public void create()
            {
                user adr = new user();
                menuadm.clearshow();
                Console.Write("Login - "); adr.login = Console.ReadLine();
                Console.Write("Password - "); adr.password = Console.ReadLine();
                Console.Write("roule (0-4) - "); ConsoleKeyInfo cki = Console.ReadKey();
                
                throw new NotImplementedException();
            }

            public void read()
            {
                menuadm.clearshow();
                menuadm.usertolist(logins[menuadm.lastpos]);
                menuadm.show();

                
            }

            public void update()
            {
                menuadm.clearshow();
                menuadm.usertolist(logins[menuadm.lastpos]);
                if (menuadm.main() == 6)
                {
                    Console.SetCursorPosition(menuadm.startcol, menuadm.startrow + menuadm.newpos);
                    
                };

                
            }

            public void delete()
            {
                if (stupid())
                {
                    menuadm.clearshow();
                    logins.RemoveAt(menuadm.lastpos);
                    menuadm.userstolist();
                }

                
            }

            public void find()
            {
                throw new NotImplementedException();
            }

            public admin()
            {
                
                Console.Clear();
                Console.WriteLine(curentuser.login);
                menuadm = new menu();
                int i;
                menuadm.userstolist();
                do
                {
                    i = menuadm.main();
                    switch (i)
                    {
                        case 5: break;//escape
                        case 6: read(); break;//enter (read)
                        case 7: create(); break;//f1
                        case 8: update(); break; //f2
                        case 9: delete(); break;
                        case 10: break;
                    }
                } while (i != 5);
            }
        }
        public class cashier : Icrud
        {
            public void create()
            {
                throw new NotImplementedException();
            }

            public void delete()
            {
                throw new NotImplementedException();
            }

            public void find()
            {
                throw new NotImplementedException();
            }

            public void read()
            {
                throw new NotImplementedException();
            }

            public void update()
            {
                throw new NotImplementedException();
            }
        }
        public class personnel : Icrud
        {
            menu menuadm;
            public bool stupid()
            {
                Console.SetCursorPosition(Console.WindowLeft / 2, Console.WindowTop / 2);
                Console.WriteLine("Вы в этом уверенны y/n");
                ConsoleKeyInfo cki;
                do
                {
                    cki = Console.ReadKey();
                } while ((cki.Key != ConsoleKey.Y) && (cki.Key != ConsoleKey.N));
                if (cki.Key != ConsoleKey.Y) { return true; } else { return false; }
            }

            public void create()
            {
                people adr = new people();
                menuadm.clearshow();
                Console.Write("Name - "); adr.name = Console.ReadLine();
                Console.Write("Famelename - "); adr.famelename = Console.ReadLine();
                Console.Write("Number passport - "); adr.numberpassport = Console.ReadLine();
                
                Console.Write("roule (0-4) - "); ConsoleKeyInfo cki = Console.ReadKey();
                
            }

            public void delete()
            {
                if (stupid())
                {
                    menuadm.clearshow();
                    peoplels.RemoveAt(menuadm.lastpos);
                    menuadm.piplstolist();
                }

                
            }

            public void find()
            {
                throw new NotImplementedException();
            }

            public void read()
            {
                menuadm.clearshow();
                menuadm.usertolist(logins[menuadm.lastpos]);
                menuadm.show();

                
            }

            public void update()
            {
                throw new NotImplementedException();
            }
            public personnel()
            {
                
                Console.Clear();
                Console.WriteLine(curentuser.login);
                menuadm = new menu();
                int i;
                menuadm.piplstolist();
                do
                {
                    i = menuadm.main();
                    switch (i)
                    {
                        case 5: break;//escape
                        case 6: read(); break;//enter (read)
                        case 7: create(); break;//f1
                        case 8: update(); break; //f2
                        case 9: delete(); break;
                        case 10: break;
                    }
                } while (i != 5);
            }

        }
        public class storekeeper : Icrud
        {
            menu menuadm;
            public bool stupid()
            {
                Console.SetCursorPosition(Console.WindowLeft / 2, Console.WindowTop / 2);
                Console.WriteLine("Вы в этом уверенны y/n");
                ConsoleKeyInfo cki;
                do
                {
                    cki = Console.ReadKey();
                } while ((cki.Key != ConsoleKey.Y) && (cki.Key != ConsoleKey.N));
                if (cki.Key != ConsoleKey.Y) { return true; } else { return false; }
            }

            public void create()
            {
                goods adr = new goods();
                menuadm.clearshow();
                Console.Write("Name - "); adr.name = Console.ReadLine();
                Console.Write("Cost - "); adr.cost = 66;
                Console.Write("Quantity - "); adr.quantity = 540;
            }

            public void delete()
            {
                if (stupid())
                {
                    menuadm.clearshow();
                    goodsss.RemoveAt(menuadm.lastpos);
                    menuadm.goodsstolist();
                }

                
            }

            public void find()
            {
                throw new NotImplementedException();
            }

            public void read()
            {
                menuadm.clearshow();
                menuadm.goodstolist(goodsss[menuadm.lastpos]);
                menuadm.show();

            }

            public void update()
            {
                throw new NotImplementedException();
            }
            public storekeeper()
            {
                
                Console.Clear();
                Console.WriteLine(curentuser.login);
                menuadm = new menu();
                int i;
                menuadm.goodsstolist();
                do
                {
                    i = menuadm.main();
                    switch (i)
                    {
                        case 5: break;//escape
                        case 6: read(); break;//enter (read)
                        case 7: create(); break;//f1
                        case 8: update(); break; //f2
                        case 9: delete(); break;
                        case 10: break;
                    }
                } while (i != 5);
            }

        }
        public class bookkeeper : Icrud
        {
            public void create()
            {
                throw new NotImplementedException();
            }

            public void delete()
            {
                throw new NotImplementedException();
            }

            public void find()
            {
                throw new NotImplementedException();
            }

            public void read()
            {
                throw new NotImplementedException();
            }

            public void update()
            {
                throw new NotImplementedException();
            }
        }
        public class login
        {
            string inputpass()
            {
                void backstar()
                {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write("*");
                }
                string esp = "";
                ConsoleKeyInfo cki;
                do
                {
                    cki = Console.ReadKey();
                    esp = esp + cki.KeyChar;
                    if (cki.Key != ConsoleKey.Enter)
                    {
                        backstar();
                    }

                } while ((cki.Key != ConsoleKey.Escape) && (cki.Key != ConsoleKey.Enter));

                if (cki.Key != ConsoleKey.Escape) { return esp; } else { return ""; }
            }

            public login()
            {
                user tempuser = new user();
                string tmp;
                tempuser.login = "";
                tempuser.password = "2";
                do
                {
                    Console.WriteLine("Пожалуйста, введите логин ");
                    string log = Console.ReadLine();
                    foreach (user us in logins)
                    {
                        if (us.login == log) { tempuser = us; break; }
                    }
                    if (tempuser.login == "") { Console.Clear(); Console.WriteLine("Неверный логин"); }
                } while (tempuser.login == "");
                do
                {
                    Console.WriteLine("Пожалуйста, введите пароль");
                    tmp = inputpass();
                } while (tempuser.password == tmp);
                curentuser = tempuser;
            }

        }
        public class menu
        {
            public int startcol = 10, startrow = 5;
            public int newpos, lastpos;
            string[] coun = new string[255];
            string[] couninfo = new string[255];
            private int arrcont = 0;
            public void show()
            {
                Console.SetCursorPosition(startcol - 3, startrow - 3);
                for (int i = 0; i < arrcont; i++)
                {
                    Console.SetCursorPosition(startcol, startrow + i);
                    Console.WriteLine(coun[i]);

                    Console.SetCursorPosition(startcol + 50, startrow + i);
                    Console.WriteLine(couninfo[i]);
                }
            }
            public void clearshow()
            {
                Console.SetCursorPosition(startcol - 3, startrow - 3);
                Console.WriteLine("                                                    ");

                for (int i = 0; i < arrcont; i++)
                {
                    Console.SetCursorPosition(startcol + 50, startrow + i);
                    Console.WriteLine("                                                                  ");
                }
            }

            private void showpos()
            {
                Console.SetCursorPosition(startcol - 3, startrow + lastpos);
                Console.Write(' ');

                Console.SetCursorPosition(startcol - 3, startrow + newpos);
                Console.Write('\u0010');

            }
            private int keyinfo()
            {
                ConsoleKeyInfo cki;
                Console.TreatControlCAsInput = true;
                int i = 0;
                do
                {
                    cki = Console.ReadKey();
                    switch (cki.Key)
                    {
                        case ConsoleKey.UpArrow: i = 1; break;
                        case ConsoleKey.DownArrow: i = 2; break;
                        case ConsoleKey.LeftArrow: i = 3; break;
                        case ConsoleKey.RightArrow: i = 4; break;
                        case ConsoleKey.Escape: i = 5; break;
                        case ConsoleKey.Enter: i = 6; break;
                        case ConsoleKey.F1: i = 7; break;
                        case ConsoleKey.F2: i = 8; break;
                        case ConsoleKey.F10: i = 9; break;
                        case ConsoleKey.S: i = 10; break;
                    }
                } while (i == 0);
                return i;
            }
            public int main()
            {
                
                int i;
                show();
                showpos();
                do
                {
                    i = keyinfo();
                    
                    switch (i)
                    {
                        case 1: newpos--; break;
                        case 2: newpos++; break;
                            
                    }
                    if (newpos > arrcont - 1) { newpos = 0; }
                    if (newpos < 0) { newpos = arrcont - 1; }
                    showpos();


                } while (i <= 4);
                return i;

            }
            public void userstolist()
            {
                arrcont = logins.Count;
                for (int i = 0; i < arrcont; i++)
                { coun[i] = logins[i].login; }
            }
            public void usertolist(user oh)
            {
                arrcont = 2;
                coun[0] = oh.id.ToString();
                coun[1] = oh.login;
                coun[2] = oh.password;
                
            }
            public void piplstolist()
            {
                arrcont = peoplels.Count;
                for (int i = 0; i < arrcont; i++)
                { coun[i] = peoplels[i].famelename + " " + peoplels[i].name; }
            }
            public void pipltolist(people oh)
            {
                arrcont = 4;
                coun[0] = oh.id.ToString();
                coun[1] = oh.famelename;
                coun[2] = oh.name;
                coun[3] = oh.numberpassport;
                coun[4] = oh.salary.ToString();
                
            }
            public void goodsstolist()
            {
                arrcont = goodsss.Count;
                for (int i = 0; i < arrcont; i++)
                { coun[i] = goodsss[i].name; }
            }
            public void goodstolist(goods oh)
            {
                arrcont = 4;
                coun[0] = oh.id.ToString();
                coun[1] = oh.name;
                coun[2] = oh.cost.ToString();
                coun[3] = oh.quantity.ToString();
            }

        }


        public static void shop()
        {
            user piple = new user();
            piple.id = 1;
            piple.login = "Админ";
            piple.password = "111";
            piple.roule = roule.администратор;

            logins.Add(piple);

            piple.id = 2;
            piple.login = "Кассир";
            piple.password = "111";
            piple.roule = roule.кассир;

            logins.Add(piple);

            piple.id = 3;
            piple.login = "Кадровик";
            piple.password = "111";
            piple.roule = roule.кадровик;

            logins.Add(piple);

            piple.id = 4;
            piple.login = "Кладовщик";
            piple.password = "111";
            piple.roule = roule.кладовщик;

            logins.Add(piple);

            piple.id = 5;
            piple.login = "Бухгалтер";
            piple.password = "111";
            piple.roule = roule.бухгалтер;

            logins.Add(piple);

            people men = new people();
            men.fathername = "Семчишин";
            men.name = "Илья";
            men.fathername = "Витальевич";
            men.numberpassport = "4510 45678";
            men.salary = 45000;
            peoplels.Add(men);

            goods god = new goods();
            god.name = "Ноутбуки";
            god.cost = 8999;
            god.quantity = 7;
            goodsss.Add(god);
            god.name = "Конфеты";
            god.cost = 399;
            god.quantity = 15;
            goodsss.Add(god);
            god.name = "Батарейки";
            god.cost = 99;
            god.quantity = 31;
            goodsss.Add(god);
            god.name = "Вода";
            god.cost = 26;
            god.quantity = 104;
            goodsss.Add(god);

            login loginbly = new();
            if (curentuser.roule == roule.администратор) { admin adm = new admin(); }
            if (curentuser.roule == roule.кадровик) { personnel adm = new personnel(); }
            if (curentuser.roule == roule.кладовщик) { storekeeper adm = new storekeeper(); }

        }

        static void Main(string[] args)
        {
            shop();
        }
    }
}
