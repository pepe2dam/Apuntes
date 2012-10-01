#1
Crear un procedimiento que visualice el apellido y el salario de los 5 empleados
que tengan el salario más alto
r
CREATE OR REPLACE
 PROCEDURE departamentos_empleados
 IS
    CURSOR empleados IS select apellido, salario from emple order by salario desc;
    apellido varchar(20);
    salario number;
    cont number := 0;
 BEGIN
    open empleados;
            loop
                    if cont < 6 then
                            fetch empleados into apellido, salario;
                            exit when empleados%NOTFOUND;
                            dbms_output.put_line(apellido || ' ' || salario);
                            cont := cont +1;
                    end if;
            end loop;
    close empleados;
 END departamentos_empleados;


#2
Crear un procedimiento que visualice los 2 empleados que ganan menos de cada 
oficio

 create or replace
 procedure e
 is
    cursor empleados is select apellido, salario, oficio from emple order by oficio, salario asc;
    apellido varchar(20);
    salario number;
    oficio varchar(20);
    buf_oficio varchar(20) := '';
    emps_por_oficio number := 0;
 begin
    open empleados;
    loop
            if oficio != buf_oficio then
                    fetch empleados into apellido, salario, oficio;
                    exit when empleados%notfound;
                    dbms_output.put_line(apellido);
            end if;
            buf_oficio := oficio;
    end loop;
 end e;


#3
Crear un procedimiento que permita insertar nuevos departamentos según las siguientes
especificaciones.
1. se pasará al procedimiento el nombre del departamento y la localidad
2. El procedimiento insertará la fila nueva asignando como dept_no la decena siguiente
al numero mayor de dept_no


#4
Crear un procedimiento que visualice el apellido y salario de los 5 empleados con el
salario más amplio.
