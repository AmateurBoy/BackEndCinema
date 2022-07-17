using BackEndKino.DB;
using BackEndKino.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BackEndKino.DB.DAO
{
    public class BillingsDAO : IDAO<Billing>
    {
        public Billing Add(Billing b)
        {
            using (DB.AppContext AC = new())
            {
                Billing account = b;
                
                if (AC.Accounts.FirstOrDefault(x => x.Id == account.Id) == null)
                {
                    AC.Billings.Add(account);
                    return account;
                }
                else
                {
                    throw new System.ArgumentException("Транзакция уже существует.", nameof(account));
                }

            }

        }
        public bool Delate(int id)
        {
            using (DB.AppContext AC = new())
            {
                try
                {
                    AC.Accounts.Remove(AC.Accounts.FirstOrDefault(x => x.Id == id));
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }
        public List<Billing> GetAll()
        {
            using (DB.AppContext AC = new())
            {
                var accounts = AC.Billings.ToList();
                return accounts;
            }
        }
        public Billing GetbyID(int Id)
        {
            using (DB.AppContext AC = new())
            {
                var billings = AC.Billings.FirstOrDefault(x => x.Id == Id);
                if (billings != null)
                {
                    return billings;
                }
                else
                {
                    throw new System.ArgumentException("Транзакция уже существует.", nameof(billings));
                }
                    
            }
        }
    }
}
