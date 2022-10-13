#!/bin/bash

#Datos
USER="root"
PASSWORD="Agustinaneves12$"

#ARCHIVOS
RUTA_BACKUP="/path/mysql/backup"
FECHA=$(date +"%d-%b-%Y")

#COPIA
mysqldump --user=$USER --password=$PASSWORD proyecto > $RUTA_BACKUP/$FECHA.sql

#COMPRIMIR
gzip $RUTA_BACKUP/#FECHA.sql

#ELIMINO ARCHIVOS MAS DE 15 DIAS
dias=15
find $RUTA_BACKUP/* -mtime +$dias -exec rm {} \;
