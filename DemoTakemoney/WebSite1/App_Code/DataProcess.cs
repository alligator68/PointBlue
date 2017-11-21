using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataProcess
/// </summary>
public class DataProcess
{
    DataClassesDataContext ctx;
    public DataProcess()
    {
        ctx = new DataClassesDataContext();
    }
    public bool CheckLogin(string user , string pass)
    {
        tblAcount acc = (from a in ctx.tblAcounts
                          where a._code == user && a._pass == pass
                          select a).SingleOrDefault();
        return acc != null;
    }
    
    public String getAccount(string code)
    {

        tblAcount account = (from x in ctx.tblAcounts where x._code == code select x).First();
        Account acc = new Account();
        acc.code = account._code;
        acc.pass = account._pass;
        acc.name = account._name;
        acc.current = (long)account._current;
   
        return acc.ToString();

    }

    public bool takemoney(string code, string money)
    {
        tblAcount account = (from x in ctx.tblAcounts where x._code == code select x).First();
        account._current = account._current - long.Parse(money);
        ctx.SubmitChanges();
        return true;
    }
    public bool transfer(string code, string code2, string money)
    {
        tblAcount account = (from x in ctx.tblAcounts where x._code == code select x).First();
        account._current = account._current - long.Parse(money);
        ctx.SubmitChanges();
        tblAcount tblaccount2 = (from x in ctx.tblAcounts where x._code == code2 select x).First();
        tblaccount2._current = tblaccount2._current + long.Parse(money);
        ctx.SubmitChanges();
        return true;
    }



}