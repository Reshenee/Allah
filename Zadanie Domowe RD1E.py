# Zadanie 1

# a = int(input())
# b = int(input())
#
# suma = (a + b)
# if (suma % 2 == 0):
#     print("TAK");
# else:
#     print("NIE");


# Zadanie 2

# a = int(input())
# g = int(input())
#
# iloczyn = (a * g)
# sr_geo = (iloczyn ** 0.5)
#
# sr_ary = (iloczyn / 2)
#
# if (sr_ary > sr_geo):
#     print("TAK");
# else:
#     print("NIE");


# Zadanie 3


# k = int(input())
# l = int(input())
# m = int(input())
#
# if (k==l and m!=k and m!=l):
#     print("TAK równe są ", k, "i", l)
# else:
#     if (k!=l and m==k and m!=l):
#         print("TAK, równe są ", m,"i", k)
#     else:
#         if (k!=l and m!=k and m==l):
#             print("TAK, równe są ", m,"i", l)
#         else:
#             print("NIE, żadna z nich nie jest równa lub wszystkie 3 są równe.")


# Zadanie 4

# a = int(input())
# b = int(input())
# c = int(input())
# d = int(input())
#
# if ((a < b)  and (a < c) and (a < d)):
#     print("Najmniejsza liczba to",(a));
# if ((b < a)  and (b < c) and (b < d)):
#     print("Najmniejsza liczba to",(b))
# if ((c < a)  and (c < b) and (c < d)):
#     print("Najmniejsza liczba to", (c))
# if ((d < a)  and (d < b) and (d < c)):
#     print("Najmniejsza liczba to", (d))


# Zadanie 5

# a = int(input())
# b = int(input())
# c = int(input())
#
# if (a < (b + c)) and (b < (a + c)) and (c < (a+b)):
#     print("TAK")
# else:
#     print("NIE")


# Zadanie 6


# a = int(input())
# b = int(input())
# c = int(input())
#
#
# if (a*a+b*b == c*c) or (a*a+c*c == b*b) or (c*c+b*b == a*a):
#     print("Prostokątny")
# else:
#     if (a*a+b*b < c*c) or (a*a+c*c < b*b) or (c*c+b*b < a*a):
#         print("Rozwartokątny")
#     else:
#         if (a*a+b*b > c*c) or (a*a+c*c > b*b) or (c*c+b*b > a*a):
#             print("Ostrokątny")




k = int(input())
l = int(input())
m = int(input())

if (k == l) and (l != m) and (m != k):
    print("TAK", k, l)
else:
    if (k != l) and (l == m) and (m != k):
        print("TAK", l, m)
    else:
        if (k != l) and (l != m) and (m == k):
            print("TAK", m, k)
        else:
            print("NIE")