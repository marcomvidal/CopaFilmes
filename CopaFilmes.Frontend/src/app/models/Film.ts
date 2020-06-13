export class Film {
    id: string;
    titulo: string;
    ano: number;
    nota: number;

    constructor(id: string, titulo: string, ano: number, nota: number) {
        this.id = id;
        this.titulo = titulo;
        this.ano = ano;
        this.nota = nota;
    }
}