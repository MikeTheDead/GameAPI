﻿using LobbyAPI.Models;

namespace LobbyAPI.Interfaces;

public interface IMongoSessionExtension
{
    Task<Session?> Get(string value);
    Task<List<Session>> GetAll();
    Task Set(Session value);
    Task PutConnectionID(Session value);
    Task PutPlayer(Session value);
    Task Remove(Session value);
    public Task<PlayerKey> GetKVPOfSession(Session value);
    public Task SubmitPlayerUpdate(Session session);
}