def validateDecimal(number):
    num = str(number)
    decimals = num.split('.')
    if(len(decimals) > 1 and len(decimals[1]) > 1):
        return False
    return True

while True:
    try:
        periodOne = 0; periodTwo = 0; periodThree = 0; exam = 0
        # Primer periodo
        while True:
            periodOne = float(input("Nota del primer periodo: "))
            if (periodOne < 0 or periodOne > 10):
                print("La nota no puede ser menor a 0 o mayor a 10")
            elif not (validateDecimal(periodOne)):
                print("La nota puede tener máximo un decimal")
            else:
                break
        # Segundo periodo
        while True:
            periodTwo = float(input("Nota del segundo periodo: "))
            if (periodTwo < 0 or periodTwo > 10):
                print("La nota no puede ser menor a 0 o mayor a 10")
            elif not (validateDecimal(periodTwo)):
                print("La nota puede tener máximo un decimal")
            else:
                break
        # Aprueba o Reprueba
        if (periodOne > 9 and periodTwo > 9):
            mensaje = "APROBADO"
        elif (periodOne < 2 and periodTwo < 2):
            mensaje = "REPROBADO"
        else:
            # Tercer periodo
            while True:
                periodThree = float(input("Nota del tercer periodo: "))
                if (periodThree < 0 or periodThree > 10):
                    print("La nota no puede ser menor a 0 o mayor a 10")
                elif not (validateDecimal(periodThree)):
                    print("La nota puede tener máximo un decimal")
                else:
                    break
            # Promedio
            average = (periodOne + periodTwo + periodThree)/3
            # Aprueba o Reprueba
            if (average < 3):
                mensaje = "REPROBADO"
            elif (average >= 7):
                mensaje = "APROBADO"
            else:
                # Examen de recuperación
                while True:
                    exam = float(input("Nota del examen de recuperación: "))
                    if (exam < 0 or exam > 10):
                        print("La nota no puede ser menor a 0 o mayor a 10")
                    elif not (validateDecimal(exam)):
                        print("La nota puede tener máximo un decimal")
                    else:
                        break
                # Aprueba o reprueba
                if (exam < 5):
                    mensaje = "REPROBADO"
                else:
                    mensaje = "APROBADO"
        print(mensaje)
        break
    except ValueError as e:
        print("An error has occurred! ", e)