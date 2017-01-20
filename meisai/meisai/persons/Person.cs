using meisai.persons.career;
using meisai.persons.money;
using meisai.persons.relation;
using meisai.persons.state;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meisai.persons
{
    /*
     * 这个类是个人，包括几个类：状态、金钱、事业、关系
     */
    class Person
    {
        PersonState state = new PersonState();
        PersonMoney money = new PersonMoney();
        PersonCareer career = new PersonCareer();
        PersonRelationShip relationShip = new PersonRelationShip();

        //这个是每一段时间以后调用一下，人可以挣钱，花钱，交换钱，交友，生子等等
        public void deltaTAfter(int day = 365)
        {

        }
        public int getMyMoney()
        {
            return money.Money();
        }
    }
}
