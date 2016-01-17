namespace Rosalind.Solutions

open System
open System.IO

module CountingDNANucleotides =

  let dnaChain = "AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC"

  let data =
    "Rosalind.Solutions/input/rosalind_dna.txt"
    |> File.ReadAllText

  let countLetter sequence letter =
    sequence
    |> Seq.filter (fun s -> s = letter)
    |> Seq.length

  let adenine = countLetter dnaChain 'A'

  let cytosine = countLetter dnaChain 'C'

  let guanine = countLetter dnaChain 'G'

  let thymine = countLetter dnaChain 'T'

  let countMolecules =
    printf "%d %d %d %d" adenine cytosine guanine thymine
