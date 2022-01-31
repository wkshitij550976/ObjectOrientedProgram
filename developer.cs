using System;

public abstract class developer
{
                    private string _MainDevelopLang;

                    public developer(string Language)
                    {
                                        this._MainDevelopLang = Language;
                    }

                    

                    public void code()
                    {
                                        Console.WriteLine("my favourite language is {0} ",this._MainDevelopLang);
                    }

                    
}