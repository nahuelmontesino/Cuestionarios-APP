﻿namespace Cuestionarios.Models.DAL
{
    interface IUnitOfWork
    {
        void Complete();

        QuestionRepository QuestionRepository { get; }

        SetRepository SetRepository { get; }

        SessionRepository SessionRepository { get; }
    }
}