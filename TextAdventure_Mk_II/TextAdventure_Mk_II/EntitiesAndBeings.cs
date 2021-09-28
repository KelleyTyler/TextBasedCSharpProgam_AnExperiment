using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure_Mk_II
{
    class Entity
    {
        //all beings and entities
        String name;
        String desc;
        int cHP, maxHP;//cHP=current HP, maxHP=maximum Hitpoints
        int xx, yy;//location in the game world
        Stats atk_stat;
        Stats def_stats;
        int power; //this stat is how damage is calculated;
        StorePack BPack;
        bool alive;
        public Entity()
        {
            name = "none";
            desc = "none";
            cHP = 0;
            maxHP = 0;
            xx = 0;
            yy = 0;
            atk_stat = Useful.StatInit(0, 0, 0);
            def_stats = Useful.StatInit(0, 0, 0);
            alive = true;
            power = 1;
            BPack = new StorePack();
        }
        public Entity(string name, string desc, int mhp, int x, int y, int power, Stats atk_stat, Stats def_stats)
        {
            this.name = name;
            this.desc = desc;
            this.maxHP = mhp;
            this.cHP = mhp;
            this.xx = x;
            this.yy = y;
            this.power = power;
            this.atk_stat = atk_stat.RetStats();
            this.def_stats = def_stats.RetStats();
            alive = true;
            BPack = new StorePack();
            BPack.addItem(Useful.Fist);
        }
        public void SetAtk(int r, int p, int s)
        {
            atk_stat.setInitVals(r, p, s);
        }

        public String getName()
        {
            return this.name;
        }
        public void SetDef(int r, int p, int s)
        {
            def_stats.setInitVals(r, p, s);
        }
        public Stats getDef()
        {
            return def_stats;
        }
        public Stats getAtk()
        {
            return atk_stat;
        }
        public int getPower()
        {
            return power;
        }
        public Stats getDefBonus()
        {
            return BPack.calcDef();
        }
        public void addItemToInv(Item a)
        {
            BPack.addItemCopy(a);
        }


        public void Damage(int a)
        {
            this.cHP = this.cHP - a;
            if(cHP<0)
            {
                Console.WriteLine("{0} is Down",this.name);
                alive = false;
            }
        }
        public bool isAlive()
        {

            return alive;

        }

        public Item getDwep()
        {
            return BPack.getDWEP();
        }

        public String getHPRatio()
        {
            return String.Format("{0}/{1}",cHP,maxHP);
        }
        public void PrintChar()
        {
            Console.WriteLine("\t{0}\n\t----DESCRIPTION----\n\t{1}\n\t-------STATS---------\n\tHP:{2}/{3}\n\tGOLD:{4}\n\tATK:{5}\n\tDEF:{6}",this.name, this.desc, this.cHP, this.maxHP, this.BPack.getGold(), this.atk_stat.printStats(),def_stats.printStats());
            Console.WriteLine("\n\tInventory:\n\t------------------");
            BPack.PrintInventory();
            Console.WriteLine("\n\n\n");
            //
        }

    }

    class Body
    {

    }

    class Limb
    {
        bool hasInv;
        bool hasConnect;
    }

}
