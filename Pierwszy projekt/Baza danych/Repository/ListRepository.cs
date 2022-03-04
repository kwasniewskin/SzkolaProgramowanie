using Quiz.Baza_danych.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using Baza_danych.Dto;
using Baza_danych.Automapper;

namespace Baza_danych.Repository
{
    public class ListRepository : IRepository
    {
        List<Pytanie> pytanieList;
        List<Odpowiedz> odpowiedziList;


        QuizAutomaper quizAutomaper = new QuizAutomaper();

        public ListRepository()
        {
            pytanieList = new List<Pytanie>();
            odpowiedziList = new List<Odpowiedz>();

            //przykładowe pytania
            int idPytania = CreatePytanie("Ile wynosi wynik operacji 2+2?");

            CreateOdpowiedz(idPytania, "2");
            CreateOdpowiedz(idPytania, "4", true);
            CreateOdpowiedz(idPytania, "6");

            idPytania = CreatePytanie("Identyfiaktory dostępu do składowych klasy to:");

            CreateOdpowiedz(idPytania, "virtual");
            CreateOdpowiedz(idPytania, "public", true);
            CreateOdpowiedz(idPytania, "private", true);
            CreateOdpowiedz(idPytania, "static");

        }

        #region CRUD

        #region Create

        private int CreatePytanie(string trescPytania)
        {
            Pytanie pytanie = new Pytanie();
            pytanie.Id = pytanieList.Count == 0 ? 0 : pytanieList.Max(pytanie => pytanie.Id) + 1;
            pytanie.TrescPytania = trescPytania;

            pytanieList.Add(pytanie);

            return pytanie.Id;
        }

        private int CreateOdpowiedz(int idPytania, string trescOdpowiedzi, bool czyPoprawna = false)
        {
            Odpowiedz odpowiedz = new Odpowiedz();
            odpowiedz.Id = odpowiedziList.Count == 0 ? 0 : odpowiedziList.Max(odpowiedz => odpowiedz.Id) + 1;
            odpowiedz.TrescOdpowiedzi = trescOdpowiedzi;
            odpowiedz.CzyPoprawna = czyPoprawna;
            odpowiedz.PytanieId = idPytania;
            odpowiedziList.Add(odpowiedz);

            return odpowiedz.Id;
        }

        public int CreatePytanie(PytanieCreateDto pytanieCreateDto)
        {
            Pytanie pytanie = new Pytanie();
            pytanie.Id = pytanieList.Count == 0 ? 0 : pytanieList.Max(pytanie => pytanie.Id) + 1;
            pytanie.TrescPytania = pytanieCreateDto.TrescPytania;

            pytanieList.Add(pytanie);

            return pytanie.Id;
        }

        public void CreateOdpowiedz(OdpowiedzCreateDto odpowiedzCreateDto)
        {
            Odpowiedz odpowiedz = quizAutomaper.Mapper.Map<Odpowiedz>(odpowiedzCreateDto);
            odpowiedz.Id = odpowiedziList.Count == 0 ? 0 : odpowiedziList.Max(odpowiedz => odpowiedz.Id) + 1;
            odpowiedziList.Add(odpowiedz);
        }

        #endregion

        #region Read

        public int ReadPytaniaCount()
        {
            return pytanieList.Count;
        }

        public List<int> ReadPytaniaIdList()
        {
            List<int> result = pytanieList.Select(pytanie => pytanie.Id).ToList();
            return result;
        }

        public List<PytanieReadDto> ReadPytania()
        {
            List<PytanieReadDto> pytanieReadDtoLista = quizAutomaper.Mapper.Map<List<PytanieReadDto>>(pytanieList);

            return pytanieReadDtoLista;
        }

        public List<PytanieReadDto> ReadRandomPytania(int count)
        {
            Random rng = new Random();
            count = Math.Min(count, pytanieList.Count);
            List<Pytanie> randomList = pytanieList.OrderBy((Pytanie pytanie) => rng.Next()).Take(count).ToList();
            return quizAutomaper.Mapper.Map<List<PytanieReadDto>>(randomList);
        }

        public PytanieReadDto ReadPytanie(int id)
        {
            Pytanie result = pytanieList.FirstOrDefault(pytanie => pytanie.Id == id);
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
            List<Odpowiedz> result = odpowiedziList.Where(odpowiedz => odpowiedz.PytanieId == idPytania).ToList();
            if (result == null)
                result = new List<Odpowiedz>();
            List<OdpowiedzReadDto> resultDto = quizAutomaper.Mapper.Map<List<OdpowiedzReadDto>>(result);
            return resultDto;
        }

        public List<OdpowiedzReadDto> ReadOdpowiedzi(List<int> idPytaniaLista)
        {
            List<Odpowiedz> result = odpowiedziList.Where(odpowiedz => idPytaniaLista.Contains(odpowiedz.PytanieId)).ToList();
            if (result == null)
                throw new Exception("Nie znaleziono elementu");
            List<OdpowiedzReadDto> resultDto = quizAutomaper.Mapper.Map<List<OdpowiedzReadDto>>(result);
            return resultDto;
        }

        #endregion

        #region Update

        public bool UpdatePytanie(PytanieUpdateDto pytanieUpdateDto)
        {
            Pytanie pytanieDoUpdate = pytanieList.FirstOrDefault(pyt => pyt.Id == pytanieUpdateDto.Id);
            if (pytanieDoUpdate == null)
                return false;

            quizAutomaper.Mapper.Map(pytanieUpdateDto, pytanieDoUpdate);
            return true;
        }

        public bool UpdateOdpowiedz(OdpowiedzUpdateDto odpowiedzUpdateDto)
        {
            Odpowiedz odpowiedzDoUpdate = odpowiedziList.FirstOrDefault(odp => odp.Id == odpowiedzUpdateDto.Id);
            if (odpowiedzDoUpdate == null)
                return false;
            quizAutomaper.Mapper.Map(odpowiedzUpdateDto, odpowiedzDoUpdate);
            return true;
        }

        #endregion

        #region Delete

        public void DeletePytanie(PytanieDeleteDto pytanieDeleteDto)
        {
            pytanieList.RemoveAll(pytanie => pytanie.Id == pytanieDeleteDto.Id);
        }

        public void DeleteOdpowiedz(OdpowiedzDeleteDto odpowiedzDeleteDto)
        {
            odpowiedziList.RemoveAll(odpowiedz => odpowiedz.Id == odpowiedzDeleteDto.Id);
        }

        public void DeleteOdpowiedz(List<OdpowiedzDeleteDto> odpowiedzDeleteDtoList)
        {
            odpowiedzDeleteDtoList.ForEach(odpowiedzDeleteDto => DeleteOdpowiedz(odpowiedzDeleteDto));
        }

        #endregion

        #endregion
    }
}
