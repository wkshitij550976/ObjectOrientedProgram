using System;

public abstract class saleperson
{
                    private string _FirstName;
                    private string _lastname;

                    public saleperson(string firstname, string lastname)
                    {
                                        this._FirstName = firstname;
                                        this._lastname= lastname;
                    }

                    public string fullname
                    {
                                        get
                                        {
                                                            return string.Format("{0} {1}",this._FirstName,this._lastname);
                                        }
                    }

                    public abstract void sell();
}