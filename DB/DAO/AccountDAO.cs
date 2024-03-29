﻿using BackEndKino.DB;
using BackEndKino.Entitys;
using Microsoft.AspNetCore.Cors;
using System.Collections.Generic;
using System.Linq;

namespace BackEndKino.DB.DAO
{
    public class AccountDAO : IDAO<Account>
    {
        public Account Add(Account acc)
        {
            using(ApplicationContext AC = new())
            {
                Account account = acc;
                               
                if (AC.Accounts.FirstOrDefault(x => x.Id == account.Id) == null)
                {
                    AC.Accounts.Add(account);
                    AC.SaveChanges();
                    return account;
                }
                else
                {
                    throw new System.ArgumentException("Акаунт уже существует", nameof(account));
                }
                
            }
            
        }
        public bool Delate(int id)
        {
            using(ApplicationContext AC = new())
            {
                try
                {
                    AC.Accounts.Remove(AC.Accounts.FirstOrDefault(x => x.Id == id));
                    AC.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
                
            }
        }
        public List<Account> GetAll()
        {
            using (ApplicationContext AC = new())
            {
                var accounts = AC.Accounts.ToList();                
                return accounts;
            }
        }
        public Account GetbyID(int Id)
        {
            using (ApplicationContext AC = new())
            {
                var account = AC.Accounts.FirstOrDefault(x => x.Id == Id);
                if ( account != null)
                {
                    return account;
                }
                else
                {
                    throw new System.ArgumentException("Акаунт не найден", nameof(account));
                }
                   
                    
            }
        }
    }
}
