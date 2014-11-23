main:
	add #$1
	add #$1
	ba done
	add #$100
	add #$100
done:
	add #$1
	ba end
	add #$100
	add #$100
end:
	nop