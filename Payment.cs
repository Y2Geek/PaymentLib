using System;

namespace PaymentLib
{
    public class Payment
    {
        protected bool _credit;
        protected DateTime _date;
        protected string _name;
        protected decimal _value;

        /// <summary>
        /// Constructs a basic payment
        /// </summary>
        /// <param name="date">DateTime object representing payment date</param>
        /// <param name="name">string representation of the payment name</param>
        public Payment(bool credit, DateTime date, string name, decimal value)
        {
            this._credit = credit;
            this._date = date;
            this._name = name;
            this._value = value;
        }

        /// <summary>
        /// Property to return true if payment is a credit, false if a debit
        /// </summary>
        /// <value></value>
        public bool Credit
        {
            get
            {
                return this._credit;
            }
        }
        /// <summary>
        /// Property to get and set the date attribute
        /// </summary>
        /// <value>DateTime object representing the new date</value>
        public DateTime Date
        {
            get
            {
                return this._date;
            }
            set
            {
                this._date = value;
            }
        }
        /// <summary>
        /// Property to get and set the name attribute
        /// </summary>
        /// <value>string representing the new name</value>
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
        public decimal Value
        {
            get
            {
                return this._value;
            }
        }
        public override string ToString()
        {
            return this._credit + "\t" + this._date.ToString("d") + "\t" + this._name + "\t" + this._value;
        }
    }
}
