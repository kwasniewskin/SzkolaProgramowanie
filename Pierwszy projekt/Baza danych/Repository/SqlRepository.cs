using Baza_danych.Automapper;
using Baza_danych.Context;
using Baza_danych.Dto;
using Microsoft.EntityFrameworkCore;
using Quiz.Baza_danych.Model;
using System;
using System.Collections.Generic;
using System.Linq;

/*
 The instance of entity type 'Odpowiedz' cannot be tracked because another instance
with the same key value for {'Id'} is already being tracked. When attaching existing 
entities, ensure that only one entity instance with a given key value is attached. 
Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see the 
conflicting key values.
*/

namespace Baza_danych.Repository
{
    public class SqlRepository : IRepository
    {
        SqlDbContext sqlDbContext;
        QuizAutomaper quizAutomaper = new QuizAutomaper();

        public SqlRepository()
        {
            sqlDbContext = new SqlDbContext();
        }

        #region CRUD

        #region Create
        public int CreatePytanie(PytanieCreateDto pytanieCreateDto)
        {
            Pytanie pytanie = new Pytanie();
            pytanie.TrescPytania = pytanieCreateDto.TrescPytania;

            var wynik = sqlDbContext.Pytania.Add(pytanie);
            sqlDbContext.SaveChanges();
            return wynik.Entity.Id;
        }

        public void CreateOdpowiedz(OdpowiedzCreateDto odpowiedzCreateDto)
        {
            Odpowiedz odpowiedz = quizAutomaper.Mapper.Map<Odpowiedz>(odpowiedzCreateDto);
            sqlDbContext.Odpowiedzi.Add(odpowiedz);
            sqlDbContext.SaveChanges();
        }

        #endregion

        #region Read

        public int ReadPytaniaCount()
        {
            return sqlDbContext.Pytania.ToList().Count;
        }

        public List<int> ReadPytaniaIdList()
        {
            List<int> result = sqlDbContext.Pytania.Select(pytanie => pytanie.Id).ToList();
            return result;
        }

        public List<PytanieReadDto> ReadPytania()
        {
            List<PytanieReadDto> pytanieReadDtoLista = quizAutomaper.Mapper.Map<List<PytanieReadDto>>(sqlDbContext.Pytania);

            return pytanieReadDtoLista;
        }

        public List<PytanieReadDto> ReadRandomPytania(int count)
        {
            Random rng = new Random();
            count = Math.Min(count, sqlDbContext.Pytania.ToList().Count);
            List<Pytanie> randomList = sqlDbContext.Pytania.ToList().OrderBy((Pytanie pytanie) => rng.Next()).Take(count).ToList();
            return quizAutomaper.Mapper.Map<List<PytanieReadDto>>(randomList);
        }

        public PytanieReadDto ReadPytanie(int id)
        {
            Pytanie result = sqlDbContext.Pytania.FirstOrDefault(pytanie => pytanie.Id == id);
            if (result == null)
                result = new Pytanie()
                {
                    Id = -1
                };
            PytanieReadDto resultDto = quizAutomaper.Mapper.Map<PytanieReadDto>(result);
            return resultDto;
        }

        public List<OdpowiedzReadDto> ReadOdpowiedzi(int idPytania)
        {
            List<Odpowiedz> result = sqlDbContext.Odpowiedzi.Where(odpowiedz => odpowiedz.PytanieId == idPytania).ToList();
            if (result == null)
                result = new List<Odpowiedz>();
            List<OdpowiedzReadDto> resultDto = quizAutomaper.Mapper.Map<List<OdpowiedzReadDto>>(result);
            return resultDto;
        }

        public List<OdpowiedzReadDto> ReadOdpowiedzi(List<int> idPytaniaLista)
        {
            List<Odpowiedz> result = sqlDbContext.Odpowiedzi.Where(odpowiedz => idPytaniaLista.Contains(odpowiedz.PytanieId)).ToList();
            if (result == null)
                throw new Exception("Nie znaleziono elementu");
            List<OdpowiedzReadDto> resultDto = quizAutomaper.Mapper.Map<List<OdpowiedzReadDto>>(result);
            return resultDto;
        }

        #endregion

        #region Update

        public bool UpdatePytanie(PytanieUpdateDto pytanieUpdateDto)
        {
            Pytanie pytanieDoUpdate = sqlDbContext.Pytania.FirstOrDefault(pyt => pyt.Id == pytanieUpdateDto.Id);
            if (pytanieDoUpdate == null)
                return false;

            quizAutomaper.Mapper.Map(pytanieUpdateDto, pytanieDoUpdate);
            sqlDbContext.SaveChanges();
            return true;
        }

        public bool UpdateOdpowiedz(OdpowiedzUpdateDto odpowiedzUpdateDto)
        {
            Odpowiedz odpowiedzDoUpdate = sqlDbContext.Odpowiedzi.FirstOrDefault(odp => odp.Id == odpowiedzUpdateDto.Id);
            if (odpowiedzDoUpdate == null)
                return false;
            quizAutomaper.Mapper.Map(odpowiedzUpdateDto, odpowiedzDoUpdate);
            sqlDbContext.SaveChanges();
            return true;
        }

        #endregion

        #region Delete

        public void DeletePytanie(PytanieDeleteDto pytanieDeleteDto)
        {
            sqlDbContext.Pytania.RemoveRange(sqlDbContext.Pytania.FirstOrDefault(pytanie => pytanie.Id == pytanieDeleteDto.Id));
            sqlDbContext.SaveChanges();
        }

        public void DeleteOdpowiedz(OdpowiedzDeleteDto odpowiedzDeleteDto)
        {
            sqlDbContext.Odpowiedzi.Remove(sqlDbContext.Odpowiedzi.FirstOrDefault(odpowiedz => odpowiedz.Id == odpowiedzDeleteDto.Id));
            sqlDbContext.SaveChanges();
        }

        public void DeleteOdpowiedz(List<OdpowiedzDeleteDto> odpowiedzDeleteDtoList)
        {
            odpowiedzDeleteDtoList.ForEach(odpowiedzDeleteDto => DeleteOdpowiedz(odpowiedzDeleteDto));
        }

        #endregion

        #endregion
    }
}
