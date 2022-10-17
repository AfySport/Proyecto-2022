salir=0
while [ $salir -ne 8 ]
do
	yad --title="Menu YAD de administrador" \
	    --center \
	    --width=150 \
	    --height=150 \
	    --text-align=center \
	    --text="Elija su opciòn" \
	    --button=Estado MYSQL:0 \
	    --button=Inicio Mysql:1 \
	    --button=Detener MySQL:2 \
	    --button=Who:3 \
	    --button=PS:4 \
	    --button=Netstat:5 \
	    --button=Nmap:6 \
	    --button=Limpiar:7 \
	    --button=Salir:8 
	ans=$?
	if [ $ans -eq 0 ]
	then
	    echo "Estado"
	    sudo systemctl status mysqld | grep "active"
	elif [ $ans -eq 1 ]
	then
	    echo "Mysql inicializado correctamente"
	    sudo systemctl start mysqld
	elif [ $ans -eq 2 ]
	then
	    echo "Mysql detenido exitosamente"
	    sudo systemctl stop mysqld
	elif [ $ans -eq 3 ]
	then
	    who
	elif [ $ans -eq 4 ]
	then
	    ps
	elif [ $ans -eq 5 ]
	then
	    netstat -punta
	elif [ $ans -eq 6 ]
	then
	    echo "Puertos Activos"
	    nmap -p 22,3306,80,433 localhost 
	elif [ $ans -eq 7 ]
	then
	    clear	
	elif [ $ans -eq 8 ]
	then
	    salir=8
	fi	
done
