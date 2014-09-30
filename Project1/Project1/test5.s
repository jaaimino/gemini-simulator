main:
	lda #$3
	sta $0 ! Reserve mem loc 0 for x
	lda #$0
	sta $1 ! Reserve mem loc 1 for y
	! z can be 2
! Should do loop until y reaches 0
check:
	lda $1
	be rehash
loop:
	lda #$2
	sta $2 ! Reserve mem loc 2 for z
	lda $0 ! Load x back in
	div $2 ! Divide by z
	sta $1 ! Store it where y is
	lda $2 ! Load z back in
	add $0 ! Add x to z
	sta $2 ! Store z back in mem loc 2
	! Now see if y is 9
	lda $1 ! Load y back in
	sub #$9 ! Subtract 9 from y
	be rehash
	ba check
! This one should be painful... :(
rehash:
	lda $1 ! Load y back in
	and $0 ! y & x
	sta $3 ! Store temporary result in mem loc 3 (Probably is a better way)
	lda $0 ! Load back in x
	or $1 ! x or y
	sta $4 ! Store temporary result in mem loc 4 (Probably is a better way)
	lda $3 ! Load back in old temp
	and $4 ! and of two temps
	sta $1 ! Put result in y spot
out:
	lda $1 ! Put y back into acc
