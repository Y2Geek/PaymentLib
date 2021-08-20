using System;
using System.Collections.Generic;

namespace PaymentLib
{
    public class Account
    {
        protected string _name;
        protected List<Payment> _payments;

        /// <summary>
        /// Constructor to create an account with a name and an empty payment list
        /// </summary>
        /// <param name="name">Name for the account</param>
        public Account(string name)
        {
            this._name = name;
            this._payments = new List<Payment>();
        }
        /// <summary>
        /// Constructor to create an account with given name and payments list
        /// </summary>
        /// <param name="name"></param>
        /// <param name="payments"></param>
        public Account(string name, List<Payment> payments)
        {
            this._name = name;
            this._payments = payments;
        }

        /// <summary>
        /// Property to get and set the account name
        /// </summary>
        /// <value>string representing the new name of the account</value>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>
        /// Property to get and set the payments attribute
        /// </summary>
        /// <value>List<BasicPayment> representing the payments for the account</value>
        public List<Payment> Payments
        {
            get
            {
                return this._payments;
            }
            set
            {
                this._payments = value;
            }
        }

        /// <summary>
        /// Adds given payment to the payments list of account
        /// </summary>
        /// <param name="pay">Payment object to add</param>
        public void AddPayment(Payment pay)
        {
            this._payments.Add(pay);
        }

        public Tuple<decimal, decimal> GetValues()
        {
            decimal amountIn = 0.0M;
            decimal amountOut = 0.0M;

            if(_payments.Count != 0)
            {
                foreach(Payment bp in this._payments)
                {
                    if(bp.Credit == true)
                    {
                        amountIn += bp.Value;
                    }
                    else
                    {
                        amountOut += bp.Value;
                    }
                }
            }
            return new Tuple<decimal, decimal> (amountIn, amountOut);
        }
    }
}