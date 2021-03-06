﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionParcInterface
{
    class Reservation
    {
        ///Attributs
        ///

        DateTime dateDebut, dateFin;

        ///Constructeur
        ///

        public Reservation(DateTime dateDebut, DateTime dateFin)
        {
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;
        }

        ///Accesseurs
        ///

        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }

        ///Méthodes
        ///

        public int DureeReservartion( Reservation reservation )
        {
            return DateTime.Compare(reservation.DateDebut, reservation.DateFin);
        }
        public override string ToString()
        {
            string result = "";
            result = " la réservation est faite à partir de :"+dateDebut+ " jusqu'au : "+DateFin;
            return result;

        }
    }
}