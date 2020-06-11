export class Film {
    public id: string;
    public titulo: string;
    public ano: number;
    public nota: number;

    constructor(id: string, titulo: string, ano: number, nota: number) {
        this.id = id;
        this.titulo = titulo;
        this.ano = ano;
        this.nota = nota;
    }
}