using System;

public class softwaredeveloper : developer, selfdeveloping
{
                    public softwaredeveloper(string Language) : base(Language)
                    {
                    }

                    public void develop()
                    {
                                        Console.WriteLine("I develop myself by watching youtube videos");
                    }
}