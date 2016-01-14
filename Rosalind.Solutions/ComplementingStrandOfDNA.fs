namespace Rosalind.Solutions

open System
open System.IO

module ComplementingStandOfDNA =
  //let dnaString = "AAAACCCGGT"

  let data =
    "Rosalind.Solutions/input/rosalind_rna.txt"
    |> File.ReadAllLines

  let dnaString = List.ofSeq data |> List.head

  let complement symbol =
    match symbol with
    | 'A' -> 'T'
    | 'C' -> 'G'
    | 'G' -> 'C'
    | 'T' -> 'A'
    | _ -> symbol

  let transform =
    dnaString
    |> Seq.map complement
    |> Seq.toArray
    |> Array.rev
    |> Seq.iter (fun c -> printf "%c" c)
