﻿namespace GenericBizRunner
{
    /// <summary>
    /// This is an Action that takes an input and returns a status with a result TOut
    /// It updates the database and therefore requires EF SaveChanges to be called to persist the changes
    /// </summary>
    /// <typeparam name="TIn">Input to the business logic</typeparam>
    /// <typeparam name="TOut">Output from the business logic</typeparam>
    public interface IGenericActionWriteDb<in TIn, out TOut> : IGenericAction<TIn, TOut>
    {
    }
}