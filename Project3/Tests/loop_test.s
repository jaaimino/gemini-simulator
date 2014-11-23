loop:
	lda $0
	add #$1
	sta $0
	sub #$25
	be done
	ba loop
done:
	lda $0