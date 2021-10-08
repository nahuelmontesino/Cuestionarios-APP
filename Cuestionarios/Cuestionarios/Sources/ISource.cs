﻿using Cuestionarios.Domain;
using System.Collections.Generic;


namespace Cuestionarios.Sources
{
    public interface ISource
    {
        string UrlBase { get; }
        string Name { get; }
        Dictionary<int, string> CategoryDictionary { get; }
        Dictionary<int, string> DifficultyDictionary { get; }
        IEnumerable<Question> GetQuestions(string pDificulty, int pCategory, int pAmount);
    }
}
