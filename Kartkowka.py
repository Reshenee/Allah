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

