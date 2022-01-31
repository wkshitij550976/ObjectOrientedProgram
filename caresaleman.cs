using System;
public class caresaleman : saleperson
{
                    public caresaleman(string firstname, string lastname) : base(firstname, lastname)
                    {
                    }

                    public override void sell()
                    {
                                        Console.WriteLine("hii my name is {0} and i recommand to buy this pen!!", this.fullname);
                    }

                    public void develop()
                    {
                                        Console.WriteLine("I develop myself by watching youtube videos");
                    }
}