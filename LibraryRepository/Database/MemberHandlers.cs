﻿using LibraryRepository.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryRepository.Database
{
    class MemberHandlers
    {
        private const string MEMBERS_COLLECTION = "members";
        private readonly IMongoDatabase _database;
        public MemberHandlers(string dbName = "mvc-library-application")
        {
            MongoClient dbClient = new MongoClient();
            _database = dbClient.GetDatabase(dbName);
        }

        public void SaveMemberToDB(Member member)
        {
            var collection = _database.GetCollection<Member>(MEMBERS_COLLECTION);
            collection.InsertOne(member);
        }
        public List<Member> GetMembersFromDB()
        {
            var collection = _database.GetCollection<Member>(MEMBERS_COLLECTION);
            var members = collection.Find<Member>(m => true).ToList();
            return members;
        }

        public void DeleteMemberById(ObjectId memberId)
        {
            var collection = _database.GetCollection<Member>(MEMBERS_COLLECTION);
            collection.DeleteOne(m => m.Id == memberId);
        }

        internal Member GetMemberByIdFromDB(ObjectId memberId)
        {
            var collection = _database.GetCollection<Member>(MEMBERS_COLLECTION);
            return collection.Find(m => m.Id == memberId).First();
        }

        public void UpdateMember(ObjectId id, string name, int age)
        {
            var collection = _database.GetCollection<Member>(MEMBERS_COLLECTION);

            UpdateDefinition<Member> update = Builders<Member>.Update
                .Set(m => m.Name, name)
                .Set(m => m.Age, age);
            collection.UpdateOne(m => m.Id == id, update);
        }
    }
}
