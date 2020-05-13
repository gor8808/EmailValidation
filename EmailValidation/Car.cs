using System;

namespace EmailValidation
{
    class Car
    {
        private string _color;
        private string _model;
        private string _email;

        public void PrintInvalidMesage(string invalidProblem)
        {
            Console.WriteLine($"Invalid; \nProblem -- {invalidProblem}");
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                
                string name = string.Empty;
                string domainName = string.Empty;
                string fullDomainName = string.Empty;
                string topLevelDomainName = string.Empty;
                //string notAllowedChars = "(),:;<>[\\]!*+={}&^%$/''\"\"";
                string allowedChars = "abcdefghijklmnopqrstuvwxyz" + "_-.@" + "1234567890";

                if ((value.Split('@').Length - 1) != 1)
                {
                    PrintInvalidMesage("@");
                    return;
                }

                name = value.Substring(0, value.IndexOf('@'));
                fullDomainName = value.Substring(value.IndexOf('@') + 1, (value.Length - (value.IndexOf('@') + 1)));
                domainName = fullDomainName.Substring(0, fullDomainName.IndexOf('.'));


                


                if (name.Length > 20 || name.Length < 2)
                {
                    PrintInvalidMesage($"Length of name must be betwen 1 and 20 your is {name.Length}");
                    return;
                }
                if ((fullDomainName.Split('.').Length - 1) > 2 || (fullDomainName.Split('.').Length - 1) < 1)
                {
                    PrintInvalidMesage($". in domain must be lower than 2 your is {fullDomainName.Split('.').Length - 1}");
                    return;
                }
                topLevelDomainName = fullDomainName.Substring(fullDomainName.IndexOf('.') + 1,
                    fullDomainName.Length - (fullDomainName.IndexOf('.') + 1));
                Console.WriteLine($"Name -- {name}, FullDomainName -- {fullDomainName}, " +
                    $"DomainName -- {domainName}, TopLevelDomainName -- {topLevelDomainName} ");



                if (domainName.Length > 15 || domainName.Length < 2)
                {
                    PrintInvalidMesage($"Length of domainName must be betwen 1 and 15 your is {domainName.Length}");
                    return;
                }
                if (topLevelDomainName.Length > 15 || topLevelDomainName.Length < 2)
                {
                    PrintInvalidMesage($"Length of topLevelDomainName must be betwen 1 and 15 your is {topLevelDomainName.Length}");
                    return;
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (allowedChars.IndexOf(char.ToLower(value[i])) == -1)
                    {
                        PrintInvalidMesage($"{value[i]} this character not allowed");
                        return;
                    }
                }
                if (value.IndexOf('@') - 1 > 0)
                {
                    if (value[value.IndexOf('@') - 1] == '.')
                    {
                        PrintInvalidMesage(". before @");
                        return;
                    }
                }
                if (value.IndexOf('@') + 1 < value.Length)
                {
                    if (value[value.IndexOf('@') + 1] == '.')
                    {
                        PrintInvalidMesage(". after @");
                        return;
                    }
                }

                _email = value;
            }
        }

        



        public void InitilizeModel(string value)
        {
            _model = value;
        }

        public string ReturnModel()
        {
            return _model;
        }

        

        //public void InitilizeEmail(string value)
        //{
        //    string name = string.Empty;
        //    string domainName = string.Empty;
        //    string fullDomainName = string.Empty;
        //    string topLevelDomainName = string.Empty;
        //    //string notAllowedChars = "(),:;<>[\\]!*+={}&^%$/''\"\"";
        //    string allowedChars = "abcdefghijklmnopqrstuvwxyz" + "_-.@" + "1234567890";

        //    if ((value.Split('@').Length - 1) != 1)
        //    {
        //        PrintInvalidMesage("@");
        //        return;
        //    }

        //    name = value.Substring(0, value.IndexOf('@'));
        //    fullDomainName = value.Substring(value.IndexOf('@') + 1, (value.Length - (value.IndexOf('@') + 1)));
        //    domainName = fullDomainName.Substring(0, fullDomainName.IndexOf('.'));


        //    #region Implementation of If statement by switch/case 

        //    //switch (name.Length)
        //    //{
        //    //    case int len when len > 20:
        //    //    case int len2 when len2 < 2:
        //    //        PrintInvalidMesage($"Length of name must be betwen 1 and 20 your is {name.Length}");
        //    //        return;
        //    //    default:
        //    //        break;
        //    //}

        //    #endregion


        //    if (name.Length > 20 || name.Length < 2)
        //    {
        //        PrintInvalidMesage($"Length of name must be betwen 1 and 20 your is {name.Length}");
        //        return;
        //    }
        //    if ((fullDomainName.Split('.').Length - 1) > 2 || (fullDomainName.Split('.').Length - 1) < 1)
        //    {
        //        PrintInvalidMesage($". in domain must be lower than 2 your is {fullDomainName.Split('.').Length - 1}");
        //        return;
        //    }
        //    topLevelDomainName = fullDomainName.Substring(fullDomainName.IndexOf('.') + 1,
        //        fullDomainName.Length - (fullDomainName.IndexOf('.') + 1));
        //    Console.WriteLine($"Name -- {name}, FullDomainName -- {fullDomainName}, " +
        //        $"DomainName -- {domainName}, TopLevelDomainName -- {topLevelDomainName} ");



        //    if (domainName.Length > 15 || domainName.Length < 2)
        //    {
        //        PrintInvalidMesage($"Length of domainName must be betwen 1 and 15 your is {domainName.Length}");
        //        return;
        //    }
        //    if (topLevelDomainName.Length > 15 || topLevelDomainName.Length < 2)
        //    {
        //        PrintInvalidMesage($"Length of topLevelDomainName must be betwen 1 and 15 your is {topLevelDomainName.Length}");
        //        return;
        //    }
        //    #region not allowedChars
        //    //for(int i = 0; i< notAllowedChars.Length; i++)
        //    //{
        //    //    if (value.IndexOf(notAllowedChars[i]) != -1)
        //    //    {
        //    //        PrintNowWalidMesage($"{notAllowedChars[i]} this character not allowed");
        //    //        return;
        //    //    }
        //    //}
        //    #endregion
        //    for (int i = 0; i < value.Length; i++)
        //    {
        //        if (allowedChars.IndexOf(char.ToLower(value[i])) == -1)
        //        {
        //            PrintInvalidMesage($"{value[i]} this character not allowed");
        //            return;
        //        }
        //    }
        //    if (value.IndexOf('@') - 1 > 0)
        //    {
        //        if (value[value.IndexOf('@') - 1] == '.')
        //        {
        //            PrintInvalidMesage(". before @");
        //            return;
        //        }
        //    }
        //    if (value.IndexOf('@') + 1 < value.Length)
        //    {
        //        if (value[value.IndexOf('@') + 1] == '.') 
        //        {
        //            PrintInvalidMesage(". after @");
        //            return;
        //        }
        //    }
        //}

        


    }
}

    
