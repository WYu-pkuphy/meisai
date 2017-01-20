using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meisai.persons.money
{
    /*
     * 保存金钱相关的信息，还有挣钱花钱相关事宜
     */
    public class PersonMoney
    {
        //为简化起见，先存一个money，以后可以增加贷款信用等等
        int money;
        //每一段时间调用以下函数，个人挣钱和花钱
        public void deltaTAfter(int day = 365)
        {
            //挣钱 + 花钱
        }
        public int Money()
        {
            return money;
        }
    }
}
