using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure_Mk_II
{
    class Item
    {
        String name;
        String desc;
        double mass;
        double volume;
        Stats atk_bonus;
        Stats def_bonus;
        Stats dmg_Potential;
        int buy_Value;
        int sell_Value;
        int rarity;

        public Item()
        {
            name = "none";
            desc = "not Available";
            mass = 0.0;
            volume = 0.0;
            atk_bonus = Useful.StatInit(0, 0, 0);
            def_bonus = Useful.StatInit(0, 0, 0);
            dmg_Potential = Useful.StatInit(0, 0, 0);
        }
        public Item(String name, String description,double mass, double volume)
        {
            this.name = name;
            this.desc = description;
            this.mass = mass;
            this.volume = volume;
            atk_bonus = Useful.StatInit(0, 0, 0);
            def_bonus = Useful.StatInit(0, 0, 0);
            dmg_Potential = Useful.StatInit(0, 0, 0);
        }
        public Item(String name, String description, double mass, double volume, Stats atk, Stats def, int buy_Value,int sell_Value, int rarity)
        {
            this.name = name;
            this.desc = description;
            this.mass = mass;
            this.volume = volume;
            atk_bonus = atk.RetStats();
            def_bonus = def.RetStats();
            dmg_Potential = Useful.StatInit(0, 0, 0);
            this.buy_Value = buy_Value;
            this.sell_Value = sell_Value;
            this.rarity = rarity;

        }
        public Item(String name, String description, double mass, double volume, Stats atk, Stats def)
        {
            this.name = name;
            this.desc = description;
            this.mass = mass;
            this.volume = volume;
            atk_bonus = atk.RetStats();
            def_bonus = def.RetStats();
            dmg_Potential = Useful.StatInit(0, 0, 0);
        }


        public double getVolume()
        {
            return this.volume;
        }
        public double getMass()
        {
            return this.mass;
        }
        public int getBuyValue()
        {
            return this.buy_Value;
        }
        public int getSellValue()
        {
            return this.sell_Value;
        }
        public int getRarity()
        {
            return this.rarity;
        }
        public String getName()
        {
            return this.name;
        }
        public String getDescription()
        {
            return this.desc;
        }

        public override String ToString()
        {
            String temp = string.Format("{0}\t{1}\n\t\tMass:{2,3:0.00},Volume: {3,3:0.00}\n\t\t-ATK:{4}\n\t\t-DEF:{5}", this.name,this.desc,this.mass,this.volume,atk_bonus.printStats(),def_bonus.printStats());

            return temp;
        }

        public void SetAtk(int r, int p, int s)
        {
            this.atk_bonus.setInitVals(r, p, s);
        }
        public void SetDef(int r, int p, int s)
        {
            this.def_bonus.setInitVals(r, p, s);
        }
        public void SetDmg(int r, int p, int s)
        {
            this.dmg_Potential.setInitVals(r, p, s);
        }

        public void setBuy(int a)
        {
            this.buy_Value = a;
        }
        public void setSell(int a)
        {
            this.sell_Value = a;
        }
        public void setRare(int a)
        {
            this.rarity = a;
        }
        public Stats getAtk()
        {
            return atk_bonus;
        }
        public Stats getDef()
        {
            return def_bonus;
        }
        public Stats getDmg()//honestly not sure why I thought I needed this; think it's going to be made vestigial.
        {
            return dmg_Potential;
        }

        public virtual Item DeepCopy()
        {
            Item temp = new Item(this.name, this.desc, this.mass, this.volume,this.atk_bonus,this.def_bonus,this.buy_Value,this.sell_Value,this.rarity);
            return temp;
        }

    }

    //class Weapon : Item
    //{


    //    public Weapon():base()
    //    {

    //    }

    //    public Weapon(String name, String description, double mass, double volume):base(name,description,mass,volume)
    //    {

    //    }

    //    public new Weapon DeepCopy()
    //    {
    //        Weapon temp = new Weapon(this.getName(), this.getDescription(), this.getMass(), this.getVolume());
    //        return temp;
    //    }
    //}
}
