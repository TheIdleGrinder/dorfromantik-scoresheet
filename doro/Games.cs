﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doro
{
    public static class Games
    {
        public readonly static GameDefinition Dorfromantik = new(
            "doro",
            "Dorfromantik - Das Brettspiel",
            GameFactory.GetBaseGoals(),
            [ GameFactory.GetMillGoals(), GameFactory.GetDuelGoals() ]
        );

        public static List<GameDefinition> GetAllGames => [ Dorfromantik ];
    }
}
