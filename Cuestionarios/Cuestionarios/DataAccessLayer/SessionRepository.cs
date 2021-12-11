﻿using System.Collections.Generic;
using Npgsql;
using System;
using System.Linq;
using Cuestionarios.Domain;

namespace Cuestionarios.DataAccessLayer
{
    public class SessionRepository : Repository<Session, QuestionnaireDbContext>
    {
        public SessionRepository(QuestionnaireDbContext pContext) : base(pContext)
        {

        } 

        public void SaveSession(string pUserName, double pScoreValue, TimeSpan pTotalTime)
        {
            try
            {
                User userDB = iDbContext.Users.Where(user => user.Username == pUserName).FirstOrDefault();

                Session session = new Session
                {
                    TotalTime = pTotalTime,
                    Score = pScoreValue,
                    User = userDB,
                    Date = DateTime.Now
                };

                Add(session);

            }
            catch(Exception ex)
            {
                throw new NpgsqlException("Error trying to save session ", ex);
            }     
        }

        public IEnumerable<Session> GetHighScores()
        {
            var sessionList = new List<Session>();

            try
            {
                var query = Get(null, session => session.OrderByDescending(x => x.Score));
                sessionList = query.Take(20).ToList();
            }
            catch (Exception ex)
            {
                throw new NpgsqlException("Error trying to get scores: ", ex);
            }

            return sessionList;
        }
    }
}
