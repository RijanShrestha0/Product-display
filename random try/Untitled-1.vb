module module1
dim num(4) as integer
dim pass, i, j, k as integer
i=0
While i<=4
    console.writeline("enter number")
    num(i) = console.readline()
    i=i+1
End While
pass = 0
while pass<=3
    k=0
    while k<=3 -pass
        if num(k)>num(k+1) then
            temp =num(k)
            num(k+1)=temp
        end if
        k=k+1
    end while
    pass=pass+1
end while
j=0
while j<=4
    console.writeline(num(j))
    j=j+1
end while
end module