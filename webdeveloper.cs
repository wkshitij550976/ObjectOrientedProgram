using System;

public class webdeveloper : developer, selfdeveloping
{
                    public webdeveloper(string Language) : base(Language)
                    {

                    }

                    public void develop()
                    {
                                        Console.WriteLine("I develope myself by watching udemy videos");
                    }
}