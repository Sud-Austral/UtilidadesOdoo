﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionBlanco.Models
{
    public class EstructuraCritica
    {
        public List<Solicitud> Solicitudes { get; set; }

        public EstructuraCritica()
        {
            Solicitudes = new List<Solicitud>();
            Solicitudes.Add(new Solicitud("https://www.dataintelligence-group.com/", "Odoo"));
            Solicitudes.Add(new Solicitud("https://serviciodashboard.azurewebsites.net/", "Blackbox"));
            Solicitudes.Add(new Solicitud("https://powerbi.microsoft.com/es-es/", "PowerBI"));
            Solicitudes.Add(new Solicitud("https://www.dropbox.com/", "Dropbox"));
            Solicitudes.Add(new Solicitud("https://app-data-i.users.earthengine.app/", "Google Earth Engine"));
            Solicitudes.Add(new Solicitud("https://odooutil.azurewebsites.net/", "Utilidades Odoo"));
            Solicitudes.Add(new Solicitud("https://filtradordashboard.azurewebsites.net/", "Filtros Dashboard"));
            Solicitudes.Add(new Solicitud("https://ide.dataintelligence-group.com/mapstore/#/", "MapStore"));
            Solicitudes.Add(new Solicitud("https://ide.dataintelligence-group.com/geoserver/web/?0", "GeoServer"));
            Solicitudes.Add(new Solicitud("https://ide.dataintelligence-group.com/", "Tomcat"));
            Solicitudes.Add(new Solicitud("https://rpubs.com/dataintelligence/", "Shiny"));
            Solicitudes.Add(new Solicitud("https://github.com/Sud-Austral/", "Github"));
            Solicitudes.Add(new Solicitud("https://ezexporter.highviewapps.com/exports/export-profile/", "EZ Exporter"));
            Solicitudes.Add(new Solicitud("https://dataintelligence.store/", "Shopify"));
        }
    }
}