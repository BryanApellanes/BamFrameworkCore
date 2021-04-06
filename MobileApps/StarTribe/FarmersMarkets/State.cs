using System.Collections.Generic;
using Bam.Net;
using Bam.Net.Automation.Testing;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FarmersMarkets
{
    public class State
    {
        static State()
        {
            ByAbbreviation = new Dictionary<StateAbbreviations, State>()
            {
                {StateAbbreviations.AL, new State(StateAbbreviations.AL, States.Alabama)},
                {StateAbbreviations.AK, new State(StateAbbreviations.AK, States.Alaska)},
                {StateAbbreviations.AR, new State(StateAbbreviations.AR, States.Arkansas)},
                {StateAbbreviations.AZ, new State(StateAbbreviations.AZ, States.Arizona)},
                {StateAbbreviations.CA, new State(StateAbbreviations.CA, States.California)},
                {StateAbbreviations.CO, new State(StateAbbreviations.CO, States.Colorado)},
                {StateAbbreviations.CT, new State(StateAbbreviations.CT, States.Connecticut)},
                {StateAbbreviations.DE, new State(StateAbbreviations.DE, States.Delaware)},
                {StateAbbreviations.FL, new State(StateAbbreviations.FL, States.Florida)},
                {StateAbbreviations.GA, new State(StateAbbreviations.GA, States.Georgia)},
                {StateAbbreviations.HI, new State(StateAbbreviations.HI, States.Hawaii)},
                {StateAbbreviations.IA, new State(StateAbbreviations.IA, States.Iowa)},
                {StateAbbreviations.ID, new State(StateAbbreviations.ID, States.Idaho)},
                {StateAbbreviations.IL, new State(StateAbbreviations.IL, States.Illinois)},
                {StateAbbreviations.IN, new State(StateAbbreviations.IN, States.Indiana)},
                {StateAbbreviations.KS, new State(StateAbbreviations.KS, States.Kansas)},
                {StateAbbreviations.KY, new State(StateAbbreviations.KY, States.Kentucky)},
                {StateAbbreviations.LA, new State(StateAbbreviations.LA, States.Louisiana)},
                {StateAbbreviations.MA, new State(StateAbbreviations.MA, States.Massachusetts)},
                {StateAbbreviations.MD, new State(StateAbbreviations.MD, States.Maryland)},
                {StateAbbreviations.ME, new State(StateAbbreviations.ME, States.Maine)},
                {StateAbbreviations.MI, new State(StateAbbreviations.MI, States.Michigan)},
                {StateAbbreviations.MN, new State(StateAbbreviations.MN, States.Minnesota)},
                {StateAbbreviations.MO, new State(StateAbbreviations.MO, States.Missouri)},
                {StateAbbreviations.MS, new State(StateAbbreviations.MS, States.Mississippi)},
                {StateAbbreviations.MT, new State(StateAbbreviations.MT, States.Montana)},
                {StateAbbreviations.NC, new State(StateAbbreviations.NC, States.NorthCarolina)},
                {StateAbbreviations.ND, new State(StateAbbreviations.ND, States.NorthDakota)},
                {StateAbbreviations.NE, new State(StateAbbreviations.NE, States.Nebraska)},
                {StateAbbreviations.NH, new State(StateAbbreviations.NH, States.NewHampshire)},
                {StateAbbreviations.NJ, new State(StateAbbreviations.NJ, States.NewJersey)},
                {StateAbbreviations.NM, new State(StateAbbreviations.NM, States.NewMexico)},
                {StateAbbreviations.NV, new State(StateAbbreviations.NV, States.Nevada)},
                {StateAbbreviations.NY, new State(StateAbbreviations.NY, States.NewYork)},
                {StateAbbreviations.OH, new State(StateAbbreviations.OH, States.Ohio)},
                {StateAbbreviations.OK, new State(StateAbbreviations.OK, States.Oklahoma)},
                {StateAbbreviations.OR, new State(StateAbbreviations.OR, States.Oregon)},
                {StateAbbreviations.PA, new State(StateAbbreviations.PA, States.Pennsylvania)},
                {StateAbbreviations.RI, new State(StateAbbreviations.RI, States.RhodeIsland)},
                {StateAbbreviations.SC, new State(StateAbbreviations.SC, States.SouthCarolina)},
                {StateAbbreviations.SD, new State(StateAbbreviations.SD, States.SouthDakota)},
                {StateAbbreviations.TN, new State(StateAbbreviations.TN, States.Tennessee)},
                {StateAbbreviations.TX, new State(StateAbbreviations.TX, States.Texas)},
                {StateAbbreviations.UT, new State(StateAbbreviations.UT, States.Utah)},
                {StateAbbreviations.VA, new State(StateAbbreviations.VA, States.Virginia)},
                {StateAbbreviations.VT, new State(StateAbbreviations.VT, States.Vermont)},
                {StateAbbreviations.WA, new State(StateAbbreviations.WA, States.Washington)},
                {StateAbbreviations.WI, new State(StateAbbreviations.WI, States.Wisconsin)},
                {StateAbbreviations.WV, new State(StateAbbreviations.WV, States.WestVirginia)},
                {StateAbbreviations.WY, new State(StateAbbreviations.WY, States.Wyoming)}
            };
            ByName = new Dictionary<States, StateAbbreviations>();
            foreach (StateAbbreviations abbreviation in ByAbbreviation.Keys)
            {
                ByName.Add(ByAbbreviation[abbreviation].Name, abbreviation);
            }
        }
        
        public static implicit operator States(State state)
        {
            return state.Name;
        }

        public static implicit operator State(States state)
        {
            return new State(ByName[state], state);
        }

        public static implicit operator StateAbbreviations(State state)
        {
            return state.Abbreviation;
        }

        public static implicit operator State(StateAbbreviations state)
        {
            return ByAbbreviation[state];
        }
        
        public State(StateAbbreviations abbreviation, States state)
        {
            DisplayName = state.ToString().PascalSplit(" ");
            Abbreviation = abbreviation;
            Name = state;
        }
        
        public string DisplayName { get; set; }
        public States Name { get; set; }
        public StateAbbreviations Abbreviation { get; set; }

        public static Dictionary<StateAbbreviations, State> ByAbbreviation
        {
            get;
            set;
        }

        public static Dictionary<States, StateAbbreviations> ByName
        {
            get;
            set;
        }
    }
}