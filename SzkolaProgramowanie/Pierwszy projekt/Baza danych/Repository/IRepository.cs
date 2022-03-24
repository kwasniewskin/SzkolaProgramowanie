using Baza_danych.Dto;
using System.Collections.Generic;

namespace Baza_danych.Repository
{
    public interface IRepository
    {
        void CreateOdpowiedz(OdpowiedzCreateDto odpowiedzCreateDto);
        int CreatePytanie(PytanieCreateDto pytanieCreateDto);
        void DeleteOdpowiedz(List<OdpowiedzDeleteDto> odpowiedzDeleteDtoList);
        void DeleteOdpowiedz(OdpowiedzDeleteDto odpowiedzDeleteDto);
        void DeletePytanie(PytanieDeleteDto pytanieDeleteDto);
        List<OdpowiedzReadDto> ReadOdpowiedzi(int idPytania);
        List<OdpowiedzReadDto> ReadOdpowiedzi(List<int> idPytaniaLista);
        List<PytanieReadDto> ReadPytania();
        //int ReadPytaniaCount();
        List<int> ReadPytaniaIdList();
        PytanieReadDto ReadPytanie(int id);
        List<PytanieReadDto> ReadRandomPytania(int count);
        bool UpdateOdpowiedz(OdpowiedzUpdateDto odpowiedzUpdateDto);
        bool UpdatePytanie(PytanieUpdateDto pytanieUpdateDto);
    }
}