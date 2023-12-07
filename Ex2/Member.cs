using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public enum MemberType
    {
        Full,
        OffPeak,
        Student,
        OAP
    }
    public class Member
    {
        private string _name;
        private MemberType _type;
        private DateTime _joined;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public MemberType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public DateTime Joined
        {
            get { return _joined; }
            set { _joined = value; }
        }

        public Member(string a, MemberType b, DateTime c)
        {
            _name = a;
            _type = b;
            _joined = c;
        }

        public override string ToString()
        {
            return $"{Name}, {Type}, {Joined.ToShortDateString()}";
        }
    }
}
