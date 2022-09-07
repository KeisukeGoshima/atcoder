S = list(map(int, input()))
flag = 0
down = 0
up = 1
row = [S[6], S[3], S[7] + S[1], S[4] + S[0], S[8] + S[2], S[5], S[9]]
if S[0] == up:
    pass
else:
    for i in range(7):
        if flag == 2 and row[i] >= 1:
            print("Yes")
            exit(0)
        if flag == 1 and row[i] == 0:
            flag = 2
        if flag == 0 and row[i] >= 1:
            flag = 1
print("No")
