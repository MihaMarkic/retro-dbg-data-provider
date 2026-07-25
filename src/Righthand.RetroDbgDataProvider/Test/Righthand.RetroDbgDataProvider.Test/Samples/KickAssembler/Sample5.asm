*=$0801
.byte $0c,$08,$b5,$07,$9e,$20,$32,$30,$36,$32,$00,$00,$00
.var base=$2000
.const current=$10 // indirect address for clearing screen
jmp main

main:
	lda $D018
	ora #8
	sta $D018
	
	lda $D011
	ora #32
	sta $D011
	jmp draw
	rts
	
draw:
    lda #<base
	lda <base
	sta current
	lda >base
	sta current+1
fill:
	lda #0
	ldy #0
	ldx #$1F
loop:
	sta (current),y
	iny
	bne loop
    ldy $11
	iny
	sty $11
	ldy #0
	dex
	bne loop
	rts