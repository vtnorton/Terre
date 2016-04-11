﻿using System;
using System.IO;
using System.Linq;

namespace ProjectPasadena.Code
{
    public class AppCode
    {
        private static string[] SentencesPT = {"cherei pó", "beijei uma garota", "fumei um baseado", "transei em um carro", "tomei água da privada", "agredi alguém", "trai alguém", "fui traido por alguém", "colei na prova", "roubei algo", "fiz sexo na escola", "fiz sexo no elevador", "fiz sexo na banheira", "fiz sexo", "beijei alguém", "transei com um homem", "transei com uma mulher", "transei com um travesti", "paguei alguém por uma transa", "recebi algo por uma transa", "joguei esse jogo", "menti nesse jogo", "vi pornô gay", "peguei uma Amanda", "peguei um Thiago ou uma Carol", "usei identidade falsa", "urinei em público", "fingi ter feito algo nesse jogo que não fiz", "fui posto na rua de um bar", "roubei de uma loja", "tive sexo num lugar público", "fui apanhado por uma maigo enquanto fazia sexo", "cometi um crime", "estive bêbado no Facebook", "surpreendi os meus pais a fazerem sexo", "entrei em coma com álcool", "transei com alguém que está na sala agora mesmo", "fiz uma declaração de amor bêbado", "apareci num programa de TV", "vomitei em alguém", "viajei para outro país", "viajei para outro estado", "viajei com minha família", "vi um fantasma", "vi um ET", "usei um fake para paquerar alguém", "usei um fake para falar mal de alguém", "usei aparelho dental", "toquei a campainha e sai correndo", "tive MSN", "tive ICQ", "stalkeei alguém que eu queria ficar", "soltei um peido e prendi alguém em baixo dos cobertores para sentir o cheiro", "sofri um acidente de trânsito", "sofri bullying", "ri tanto que fiz xixi na roupa", "raspei a cabeça", "quis raspar a cabeça", "quebrei uma unha", "quebrei um dente", "quebrei alguma parte do corpo", "precisei dar mais de uma descarga para o meu coco ir embora", "pintei o cabelo", "pedi pro meu amigo(a) mentir por mim", "pedi para alguém tirar uma foto minha da internet", "pedi para alguém curtir uma foto minha na internet", "pedi para alguém compartilhar uma postagem minha na internet", "passei um trote para alguém", "passei mais de 7 dias em uma viagem", "passei mais de 30 dias em uma viagem", "passei mais de 15 dias em uma viagem", "participei de um concurso de fotografia", "participei de um concurso de dança", "participei de um concurso de canto", "participei de um campeonato de futebol", "participei de um campeonato de alguma arte marcial", "participei de um campeonato de algum esporte", "me apaixonei por alguém", "nadei em uma piscina", "mandei nudes", "mandei nudes para alguém deste grupo", "morri nessa vida", "menti que estava doente para faltar ao trabalho", "menti que estava doente", "me atrasei e perdi o ônibus", "levei um toco na frente de várias pessoas", "gravei um video meu dançando", "gravei um video meu cantando", "ganhei alguma vez em primeiro lugar", "ganhei alguma medalha", "ganhei algum troféu", "fui falar com alguém só para pedir ajuda com alguma coisa", "fui confundido com alguém", "fui a uma sauna", "fugi da escola", "foi culpado por alguma coisa que eu não fiz", "fiz uma tatuagem", "fiz um antónio nunes em alguém", "fiz alguma coisa e pensei que ia morrer", "fiz algo errado e joguei a culpa em outra pessoa", "fiquei com medo de ver um fantasma", "fiquei com alguém no cinema", "fingi não estar em casa para não cumprimentar a visita", "fingi estar dormindo para não dar o meu lugar no ônibus", "fingi estar doente para não ir para a escola", "fechei a porta do carro no meu dedo", "estive tão bravo", "engoli um mosquito", "dormi no ônibus e perdi o ponto que ia descer", "discuti com alguém pela internet", "discuti com alguém no twitter", "discuti com alguém em uma postagem no facebook", "derrubei meu celular no chão", "dei um pedala robinho em alguém", "dancei em público", "criei um fake no facebook", "comprei alguma coisa pela internet", "chorei tanto que meus olhos ficaram inchados", "cantei em público", "cai na rua", "cai de moto", "cai de bicicleta", "cai da escada", "bloqueei alguém no facebook", "bebi nenhuma bebida alcóolica", "bati o carro que dirigia", "assisti o seriado Vikings", "assisti o seriado Two and a Half Men", "assisti o seriado True Blood", "assisti o seriado The Walking Dead", "assisti o seriado The Vampire Diaries", "assisti o seriado The Big Bang Theory", "assisti o seriado The 100", "assisti o seriado Supernatural", "assisti o seriado Sleepy Hollow", "assisti o seriado Sherlok", "assisti o seriado Salem", "assisti o seriado Orange Is The New Black", "assisti o seriado Once Upon a Time", "assisti o seriado Lost Girl", "assisti o seriado Lost", "assisti o seriado How I Met Your Mother", "assisti o seriado House", "assisti o seriado Grimm", "assisti o seriado Glee", "assisti o seriado Game of Thrones", "assisti o seriado Friends", "assisti o seriado Doctor Who", "assisti o seriado Dexter", "assisti o seriado Da Vincis Demons", "assisti o seriado CSI", "assisti o seriado Breaking Bad", "assisti o seriado Bones", "assisti o seriado Arrow", "assisti o seriado American Horror Story", "transei mais de uma vez na semana", "vi meu(a) namorado(a) cagando", "viajei com um(a) namorado(a)", "troquei a hora do despertador de um amigo(a)", "transei no sofá da minha casa", "transei no sofá da casa dos meus sogros", "transei no sofá da casa dos meus pais", "transei no sofa da casa do meu namorado", "transei na casa dos pais do meu(minha) namorado(a)", "transei na casa dos meus pais", "transei na casa de algum conhecido", "transei na cama do meus pais", "transei na cama do meu irmão(ã)", "transei mais de uma vez neste mês", "transei em um local público", "transei com alguém que conheci no Tinder", "transei com alguém por dó", "transei com alguém pensando em outra pessoa", "terminei um casamento", "recebi pornografia no whatsapp", "realizei alguma fantasia sexual", "passei a mão em um(a) garoto(a) enquanto ficava com ele(a)", "namorei por mais de 6 meses", "amorei por mais de 1 ano", "namorei um(a) primo(a)", "nadei pelado(a)", "mudei o relacionamento do Facebook", "me arrependi de ter ficado com alguém", "me arrependi de não ter ficado com alguém", "me apaixonei por alguém do mesmo sexo que o meu", "mandei mensagem enquanto estava bêbado para alguém", "liguei bêbado para alguém", "fui perguntado se era gay", "fui pego pelado", "fui casado(a)", "fui a uma festa da espuma", "fui a um motel", "fui a um churrasco de pegação", "foi traído", "foi preso", "fiz sexo dentro da água", "fiquei de ressaca", "fiquei com uma pessoa 10 anos mais velha que eu", "fiquei com um(a) primo(a)", "fiquei com um professor", "fiquei com ex de um amigo(a)", "fiquei com alguém que meu(minha) amigo(a) queria ficar", "fiquei com alguém por dó", "fiquei com alguém dentro do ônibus", "fiquei com alguém", "ficaria com alguém mais baixo que eu", "falei mal de um(a) namorado(a) meu", "enviei pornografia no whatsapp", "dormi com alguém sem fazer sexo", "dirigi bebado", "dei PT", "dancei bêbado", "corri pelado na praia", "corri pelado em público", "comprei um produto erótico", "cai bêbado", "beijei na chuva", "beijei alguém", "bebi tanto que não me lembro de nada daquele dia", "bebi tanto que não lembro como voltei para casa", "achei que minha mãe imaginava que eu era gay(lésbica)", "abracei uma garota só para sentir os seios dela", "viajei com um(a) amante", "transei no banheiro da minha casa", "transei no banheiro da escola", "transei no banheiro da casa dos meus sogros", "transei no banheiro da casa dos meus pais", "transei no banheiro da casa do meu namorado", "transei na escola", "transei em um banheiro público", "transei com uma pessoa 10 anos mais velha que eu", "transei com um(a) primo(a)", "transei com um professor", "transei com mais de 2 pessoas ao mesmo tempo", "transei com alguém desse grupo", "transei com alguém desconhecido", "transei com 2 pessoas ao mesmo tempo", "transei antes de sair com os amigos", "trai um namorado(a)", "tive mais de 5 parceiros(as) sexuais", "tive mais de 1 parceiro(a) sexual", "tentei aumentar o tamanho do meu pênis", "quis ficar com alguém desse grupo", "namorei alguém do mesmo sexo que o meu", "menti para um namorado(a) meu", "menti para alguém dessa mesa", "me masturbei mais de 5 vez na semana", "me masturbei mais de 3 vez na semana", "me masturbei mais de 1 vez na semana", "me  masturbei pensando em um namorado(a) de um amigo(a)", "me  masturbei pensando em um ex-namorado(a)", "me  masturbei pensando em algum conhecido", "me  masturbei pensando em alguém deste grupo", "me  masturbei no banheiro da escola", "me  masturbei na escola", "me  masturbei em um local público", "gravei um video meu fazendo sexo", "gravei um video fazendo sexo com meu(minha) namorado(a)", "fui pego me masturbando", "fui atender um cliente que queria um(a) prostituto(a) e chegando lá era meu irmão(ã)", "fiz sexo com alguém do mesmo sexo que o meu", "fiz sexo com alguém desse grupo", "fiz sexo bebado", "fiz mais de 5 posições sexuais diferentes", "fiquei com alguém do mesmo sexo que o meu", "fiquei com alguém desse grupo", "beijei alguém do mesmo sexo que o meu", "assisti um filme pornô lésbico", "assisti um filme pornô gay", "assisti um filme pornô", "usei um Mac", "usei o Windows XP", "usei o Windows Vista", "usei o Windows ME", "usei o Windows 98", "usei o Windows 95", "usei o Windows 8", "usei o Windows 7", "usei algum Linux", "joguei World of Warcraft", "joguei Warcraft", "joguei Tibia", "joguei The Sims", "joguei Super Mario", "joguei StarCraft", "joguei Sonic", "joguei Skyrim", "joguei Ragnarok", "joguei Minecraft", "joguei Mario Kart", "joguei League of Legends", "joguei Counter Strike", "fiz cosplay", "assisti Naruto", "assisti Dragon Ball Z", "joguei RPG de mesa", "joguei Tetris", "li os livros do Assassins Creed", "li as revistas do Walking Dead", "comprei usei um iPhone", "usei um Samsumg Galaxy", "gostei do Darth Vader", "achei que o Sheldon fosse beijar alguém", "gostei de Star Trek", "gostei de Chaves", "gostei do DeadPool", "gostei do Seiya de Pegasus", "passei virus para alguém de propósito", "joguei Pac-man", "gostei do Capitão América", "assisti o filme do Dragon Ball", "joguei em um PlayStation", "joguei em um Xbox", "hackei uma conta de rede social", "quis ir para Hogwarts", "quis ter poderes especiais", "fiz sexo virtual", "namorei virtualmente", "tive amigos virtualmente", "comprei um PC só para jogos", "tirei uma nota vermelha na escola", "tirei uma nota 10 na escola", "reprovei na escola", "colei na prova", "decorei a tabuada", "gostei de matemática", "repeti de ano", "tomei suspensão na escola", "fui expulso da escola", "namorei na escola", "furei o pneu do carro de um professor", "furei o pneu do carro do diretor", "fiquei sem intervalo na escola", "briguei na escola", "fiquei com alguém da minha sala na escola", "dormi na sala de aula", "matei aula", "fugi da escola", "subi no teto da escola", "briguei com um professor", "fingi estar sentindo mal para não fazer educação física", "botei apelido em ninguém na escola", "tive apelido na escola", "comecei uma briga de bolinha de papel na escola", "joguei uma bolinha de papel na escola", "joguei papel higiênico molhado na escola", "me escondi no banheiro da escola", "dancei na escola", "joguei ovo em alguem", "entrei de penetra em uma festa", "arrotei em público", "morri de tanto rir", "participei de uma pesquisa eleitoral", "fui pego transando", "me afoguei", "quis ser membro do sexo oposto", "senti tesão em uma pessoa feia", "tomei sol completamente nú", "fui colocado na friendzone", "fiquei sem sexo tanto tempo que esqueci como era", "quebrei o coração de alguém", "soltei um pum durante o sexo oral", "soltei um pum durante o sexo", "transei no banco de trás do carro", "comi comida de cachorro", "fiz um Ménage à trois", "fiz ninguém chorar", "joguei um aviaozinho de papel na sala de aula", "fiquei com alguém dentro da sala de aula", "fiz um fio terra", "comi um chiclete que estava debaixo da mesa", "tive uma crise de riso dentro da sala de aula", "fiz ninguém chorar", "usei o Google Earth para ver minha casa", "engasguei bebendo alguma coisa", "recebi troco a mais e fiquei quieto", "chupei meu próprio sangue (só não vai se achar vampiro hein!?)", "entrei em um banheiro do sexo oposto", "bebi para ficar com alguém muito feio", "roubei uma placa de rua", "contei meus passos enquanto andava", "fiz xixi/coco no mato", "vomitei em um ônibus ou avião", "tirei uma selfie", "transei com meu(minha) melhor amigo(a)", "pensei em transar com meu(minha) melhor amigo(a)", "lambi um imã de geladeira", "pintei meu cabelo", "sai em público vestido de mulher", "sai em público vestido de homem", "dancei na chuva", "achei minha mãe gostosa", "fiz o harlem shake", "atendi o telefone enquanto fazia sexo", "lambi um pé", "transei em uma barraca", "transei no chão", "dei um soco em alguém", "dei um soco na cara de alguém", "planejei um assassinato na minha cabeça", "cantei uma música inteira", "duvidei que Deus existe", "recebi flores de ninguém", "derrubei meu celular na privada", "transei com meu(minha) chefe", "menti para conseguir transar", "fui mordido(a) por um cachorro", "cantei alto no chuveiro", "chupei um pênis", "chupei uma vagina", "lambi a orelha de alguém", "lambi o cu de alguém", "menti sobre minha sexualidade", "transei em um cemitério", "fiquei com alguém que tinha dreadlocks", "pensei em outra pessoa durante o sexo", "vomitei três vezes na mesma noite", "amarrei alguém", "fiz sexo amarrado a cama", "pintei meu quarto", "me apaixonei por um gay", "me apaixonei por uma lésbica", "engravidei alguém", "tirei vantagem de alguém que gostava de mim", "sai de casa sem calcinha/cueca", "sai de casa sem sutiã", "usei o status É complicado", "fiz sexo anal", "desenhei pornografia para mim mesmo", "pensei que fosse hetero", "pensei que fosse homossexual", "tratei alguém mal", "toquei em um pênis", "fiz xixi na cesta de lixo", "baixei uma musica ilegalmente", "comprei um CD", "usei maquiagem em mim", "maquiei alguém", "dormi em um carro a noite inteira", "roubei um taxi de alguém", "cantei a mãe de um amigo", "comi um inseto", "joguei apenas com mulheres", "joguei apenas com homens", "pulei de paraquedas", "cantei em um karaoke", "comi comida mexicana", "comi comida japonesa", "dormi fora de casa", "vi um eclipse", "fiz alguma coisa só para agradar alguém", "ouvi uma música só para agradar alguém", "assisti um filme/série só para ter assunto com alguém", "fiz sexo em público", "escrevi uma carta de amor", "fiz sexo oral em alguém", "pratiquei motocross", "andei de moto", "toquei violão para tentar conquistar alguém", "assisti um strip-tease", "fui a um club de strip-tease", "fiz sexo com uma prostituta", "cuspi esperma", "votei em um candidato e depois me arrependi", "votei no Tiririca", "engoli esperma", "toquei em uma vagina", "me masturbei com um vibrador", "fiz uma massagem em alguém", "fiz sexo no cinema", "fiz tanto barulho fazendo sexo que acordei alguém", "depilei outra pessoa", "fiz sexo em um banheiro público", "transei com um(a) ex", "fiz sexo com mais de 3 pessoas ao mesmo tempo", "beijei mais de 3 pessoas ao mesmo tempo", "fiquei chateado(a) por que alguém me chamou de gordo(a)", "estive em um cruzeiro", "menti falando que era gay", "menti falando que era lésbica", "chupei alguém em um local público", "dirigi acima da velocidade máxima", "soltei um pum em público", "cai de uma escada", "fiquei com tesão em algum parente", "fiz sexo com duas pessoas diferentes no mesmo dia", "cortei meu próprio cabelo", "fingi ser uma garota", "senti tesão na mãe/pai de um amigo(a)", "me imaginei pulando de um penhasco", "chorei por um personagem que morreu em um filme/serie", "fui chamado de viado", "fui chamada de sapatão", "fiz xixi em uma piscina", "bebi alguma coisa alcoolica quando era menor de idade", "googlei eu mesmo(a)", "soltei um pum em um elevador", "chorei assistindo Titanic", "ri durante um momento que deveria ficar em silêncio", "botei fogo em alguma coisa acidentalmente", "coloquei uma camisinha em uma banana", "usei uma banana para me masturbar", "usei um brinquedo sexual", "fiz uma tatuagem genital", "acordei depois depois do meio dia", "fui mordido por uma cobra", "olhei para os seios de uma desconhecida", "olhei para a bunda de um(a) desconhecido(a)", "olhei para o penis de um desconhecido", "tive um sonho erótico", "tive um sonho erótico com alguém desse grupo", "me inscrevi para o Big Brother Brasil", "fingi ser uma garota na internet", "fingi ser um garoto na internet", "menti para o meu melhor amigo", "trabalhei mais que 8 horas", "viajei para a Europa", "viajei para os Estados Unidos", "perguntei para um(a) garoto(a) se podia beija-lo(a)", "fiz um striptease", "fui pago(a) para fazer striptease", "dormi pelado(a)", "dormir sob as estrelas", "usei uma salsicha para me masturbar", "usei um pepino para me masturbar", "beijei um cachorro", "toquei no penis de um cachorro", "terminei com alguém no dia do seu aniversário", "Bazinga!", "terminei com alguém pelo telefone", "esfreguei minha perna na perna de outra pessoa achando que era meu(minha) namorado(a)", "fiz sexo no chão da cozinha", "dei em cima da irmã do meu amigo", "ganhei uma competição de perguntas e respostas", "me masturbei por dinheiro", "fiz um pacto com um(a) amigo(a) de casarmos se chegarmos aos 40 solteiros", "fiz sexo na cadeira do dentista", "usei meus seios para conseguir atenção de outras pessoas", "fiz cirugia plástica", "fiz botox", "fiz sexo usando roupas de latex", "me masturbei observando outras pessoas fazendo sexo", "usei a janela de um carro como espelho", "fiz sexo com uma mulher menstruada", "fiz sexo com uma grávida", "fiz sexo com uma árvore", "fiz sexo vestido de animal", "fiz sexo lambuzada(o) com chocolate", "fiz sexo sendo dominada(o)", "fiz sexo lambuzada(o) com leite condensado", "rasguei a roupa de alguém durante o sexo", "fiz sexo fantasiado(a)", "rabisquei a ultima folha do caderno", "reclamei de música alta dos meus vizinhos", "me masturbei usando uma meia", "tive mais de um número de celular", "falo comigo mesmo em voz alta", "esqueci de pegar as roupas e sai do banho pelado correndo pela casa", "fiz sexo no chuveiro", "usei pregadores de roupa em alguem fetiche sexual", "fiz sexo de óculos escuros", "parei o cronômetro em um número redondo", "fiquei com um homem estrangeiro", "fiquei com uma mulher estrangeira", "ouvi alguém falar que o meu beijo era ruim", "vi um asiático com cabelo afro", "transei na escada de incêndio", "transei em uma igreja", "enviei uma frase minha pro app que estou jogando agora", "classifiquei o app que estou jogando agora", "isse que um bebê era bonito, mesmo não sendo", "dormi em uma cama que tinha mais de duas pessoas", "fui cantada(o) por uma lésbica", "dei selinho em alguém do mesmo sexo", "dei uns pegas em alguém mentalmente", "dei uns pegas em alguém deste grupo mentalmente", "fiz nenhuma besteira bêbado(a)", "fui em uma parada gay", "menti sobre para onde eu iria sair", "me arrependi de algo que fiz", "me arrependi de algo que não fiz", "quis pegar um cantor(a)", "peguei um cantor", "simulei sexo mentalmente", "peguei na bunda de uma pessoa do mesmo sexo que eu", "sonhei que beijava alguém do mesmo sexo que eu", "tive um sonho erótico e acordei exitado(a)", "assisti hentai", "me imaginei transando com um personagem", "tive vontade de ter relações sexuais", "imaginei meus personagens de animação favoritos transando", "fiquei exitado com imagens/quadrinhos porno", "tentei sessualizar só para chamar a atenção de um garoto(a)", "imaginei as pessoas a minha volta sem roupa e se pegando", "senti vontade de saber como era o sexo sadomasoquista", "fui a um casamento que a noiva dissesse NÃO", "fiquei na frente de algum parente", "namorei", "beijei um amigo", "fiz um boquete em alguém no cinema", "transei de ponta cabeça", "fui assaltado(a)", "pensei em suicídio", "gostei de alguém que não ligava para mim", "fiquei com mais de duas pessoas na mesma noite", "imaginei alguém do grupo sem roupas", "dormi de pantufa", "fui para Nova York."};
        public static string SortNeverEver()
        {
            return SentencesPT[new Random().Next(0, SentencesPT.Length)];
        }
    }
}
