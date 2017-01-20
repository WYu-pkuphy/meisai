using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meisai.persons.state
{
    /*
     * 保存所有的信息
     */
    public class PersonState
    {
        //性别
        Gender gender = Gender.NULL;
        //种族
        Race race = Race.NULL;
        //技能
        PersonSkill skill = new PersonSkill();
    }
    public enum Gender { NULL, Male, Female}
    public enum Race { NULL , Han, Man}
    //技能状态，包括技能水平和类型等
    public class PersonSkill
    {
        //技能水平
        int level = 0;
    }
}
